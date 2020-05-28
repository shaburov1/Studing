﻿using System;
using System.IO.Ports;
using System.Threading;

namespace FuelEconomy
{
    class RemoteDevice
    {
        private MyLinkHandler link = null;
        private SerialPort port = null;
        private StatusBar statusBar = null;
        private Dashboard dashboard = null;
        private MySettings mySettings = null;
        private bool allowWork = false;
        private double fuelRate = 0;
        private int errorCount = 0;
        private Thread work = null;
        enum RequestType
        {
            byPID,
            byMAP,
            byInjectorTiming
        }

        private RequestType requestType = RequestType.byPID;
        private double FuelRate
        {
            get
            {
                return fuelRate;
            }
            set
            {
                fuelRate = value;
                dashboard.setFuelRate(fuelRate);
            }
        }
        public RemoteDevice(ref SerialPort sp, ref StatusBar sb, ref Dashboard db, ref MySettings ms)
        {
            statusBar = sb;
            port = sp;
            dashboard = db;
            mySettings = ms;

            //настроим порт
            port.ReadTimeout = 6000;
            port.NewLine = "\n";

            link = new MyLinkHandler(ref sp);
        }
        private bool verifyConnection()
        {
            if (!link.send("atz"))
                return false;
            string str = "";
            link.getAnswer(ref str, 2000);
            if (str.Contains("ELM327 v1.5"))
                return true;
            else
                return false;
        }
        private void getData()
        {
            while (allowWork)
            {
                switch (requestType)
                {
                    case RequestType.byPID: casePID(); break;
                    case RequestType.byMAP: caseMAP(); break;
                    case RequestType.byInjectorTiming: caseInjectorTiming(); break;
                }
                Thread.Sleep(200);
            }
        }
        private void casePID()
        {
            statusBar.setStatus("Подключено. Запрос данных напрямую из электронного блока управления");
            string fuelRateStr = link.getData("015E");
            double fuelRate = 0;
            try { fuelRate = Convert.ToInt32(fuelRateStr, 16) * 0.05; }
            catch { }

            //запросим обороты двигателя
            int rpm = 0;
            string strRPM = link.getData("010C");
            try { rpm = Convert.ToInt32(strRPM, 16) / 4; }
            catch { }

            dashboard.setRPM(rpm);

            if (fuelRate == 0)
                errorCount++;
            else
            {
                FuelRate = fuelRate;
                errorCount = 0;
            }
            if (errorCount > 5)
            {
                dashboard.setRPM(0);
                FuelRate = 0;
                errorCount = 0;
                requestType = RequestType.byMAP;
                return;
            }
        }
        private void caseMAP()
        {
            statusBar.setStatus("Подключено. Рассчет через показания датчика Manifold Air Pressure");
            /*  IAT - Intake Air Temperature in Kelvin - 283
             *  R - Specific Gas Constant (8.314472 J/(mol.K)
             *  MM - Average molecular mass of air (28.9644 g/mol)
             *  VE - volumetric efficiency measured in percent, let's say 85%
             *  ED - Engine Displacement in liters 1.396л.
             *  IMAP = RPM*MAP/IAT;
             *  MAF = (IMAP/120)*(VE/100)*(ED)*(MM)/(R);
             *
             *  AirFuelRatio = 14.7; // For gasoline vehicles
             *  FuelDensityGramsPerLiter = 720; // For gasoline vehicles
             *
             *  FuelFlowGramsPerSecond = MAF / AirFuelRatio;
             *  FuelFlowLitersPerSecond = FuelFlowGramsPerSecond / FuelDensityGramsPerLiter;
             *
             *  LPH = FuelFlowLitersPerSecond * 3600; // Convert to liters per hour
             */
            const double R = 8.314;
            const double ED = 1.396;
            const double MM = 28.9644;
            const int VE = 85;
            const double AirFuelRatio = 14.7;
            const int FuelDensityGramsPerLiter = 720;

            //запросим обороты двигателя
            int rpm = 0;
            string strRPM = link.getData("010C");
            try { rpm = Convert.ToInt32(strRPM, 16) / 4; }
            catch { }

            int map = 0;
            string MAP = link.getData("010B");
            try { map = Convert.ToInt32(MAP, 16); }
            catch { }

            int iat = 0;
            string IAT = link.getData("010F");
            try { iat = Convert.ToInt32(IAT, 16) + 273; }
            catch { }

            dashboard.setRPM(rpm);

            if (rpm == 0 || map == 0 || iat == 0)
            {
                errorCount++;
            }
            else
            {
                double IMAP = (double)rpm * (double)map / (double)iat;
                double MAF = (IMAP / 120.0) * ((double)VE / 100.0) * ED * MM / R;
                double FuelFlowGramsPerSecond = MAF / AirFuelRatio;
                double FuelFlowLitersPerSecond = FuelFlowGramsPerSecond / FuelDensityGramsPerLiter;
                FuelRate = FuelFlowLitersPerSecond * 3600;
                errorCount = 0;
            }

            if (errorCount > 5)
            {
                dashboard.setRPM(0);
                FuelRate = 0;
                errorCount = 0;
                requestType = RequestType.byInjectorTiming;
            }
        }
        private void caseInjectorTiming()
        {
            if (mySettings.InjectorPerformance == 0)
            {
                statusBar.setStatus("Подключено. Информация о производительности форсунок отсутствует.");
                Thread.Sleep(3000);
                FuelRate = 0;
                errorCount = 0;
                requestType = RequestType.byPID;
                return;
            }

            statusBar.setStatus("Подключено. Расчет через показания датчика времени открытия форсунок");

            string injTimingStr = link.getData("A029");
            injTimingStr = injTimingStr.Replace("E0", "");
            double injTime = 0;
            try { injTime = Convert.ToInt32(injTimingStr, 16) / 1000.0; }
            catch { }

            string strRPM = link.getData("010C");
            int rpm = 0;
            try { rpm = Convert.ToInt32(strRPM, 16) / 4; }
            catch { }

            dashboard.setRPM(rpm);

            if (injTime == 0 || rpm == 0)
                errorCount++;
            else
            {
                FuelRate = (double)rpm * injTime * (double)mySettings.InjectorPerformance / 1000.0;
                errorCount = 0;
            }

            if (errorCount > 5)
            {
                dashboard.setRPM(0);
                FuelRate = 0;
                errorCount = 0;
                requestType = RequestType.byPID;
            }
        }
        public bool connect(string portName)
        {
            if (!port.IsOpen)
            {
                port.PortName = portName;
            }
            else
            {
                string str = "Ошибка. Порт " + port.PortName + " уже открыт, необходимо отключиться от порта";
                statusBar.setStatus(str);
                return false;
            }
            try { port.Open(); }
            catch
            {
                statusBar.setStatus("Ошибка, подключение к порту невозможно");
                return false;
            }

            if (port.IsOpen)
            {
                if (verifyConnection())
                    return true;
                else
                    statusBar.setStatus("Ошибка, устройство не прошло проверку. Неизвестное устройство");
            }
            return false;
        }
        public bool init()
        {
            bool res = true;
            string answer = "";
            link.send("ATSP3");
            link.getAnswer(ref answer, 5000);
            if (!answer.Contains("OK"))
                res = false;

            link.send("ATE0");
            link.getAnswer(ref answer, 5000);
            if (!answer.Contains("OK"))
                res = false;

            if (!res)
                statusBar.setStatus("Ошибка. Невозможно инициализировать сканер.");
            return res;
        }
        public void startWork()
        {
            if (work != null)
                work.Abort();
            work = new Thread(getData);
            allowWork = true;
            work.Start();
        }
        public void stopWork()
        {
            allowWork = false;
            FuelRate = 0;
            dashboard.setRPM(0);
        }
    }
}

