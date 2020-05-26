using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FuelEconomy
{
    class RemoteDevice
    {
        private MyLinkHandler link = null;
        private Parser parser = null;
        private SerialPort port = null;
        private StatusBar statusBar = null;
        public RemoteDevice(ref SerialPort sp, ref StatusBar sb)
        {
            statusBar = sb;
            port = sp;

            //настроим порт
            port.ReadTimeout = 6000;
            port.NewLine = "\n";

            link = new MyLinkHandler(ref sp);
            parser = new Parser();
        }

        public void connect(string portName)
        {
            if (!port.IsOpen)
            {
                port.PortName = portName;
            }
            else
            {
                string str = "Ошибка. Порт " + port.PortName + " уже открыт, необходимо отключиться от порта";
                statusBar.setStatus(str);
            }
            try { port.Open(); }
            catch
            {
                statusBar.setStatus("Ошибка, подключение к порту невозможно");
            }

            if (port.IsOpen)
            {
                if (verifyConnection())
                    statusBar.setStatus($"Подключено к порту {port.PortName}");
                else
                    statusBar.setStatus("Ошибка, устройство не прошло проверку. Неизвестное устройство");
            }

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

        public bool init()
        {
            string answer = "";
            link.send("ATSP3");
            link.getAnswer(ref answer, 5000);
            if (!answer.Contains("OK"))
                return false;
            link.send("ATE0");
            link.getAnswer(ref answer, 5000);
            if (!answer.Contains("OK"))
                return false;
            return true;
        }

        public void send(string str, ref TextBox txt)
        {
            link.send(str);
            string answer = "";
            link.getAnswer(ref answer, 5000);
            txt.AppendText(answer + "\n");
        }

        public void getData(string str, ref TextBox txt)
        {
            string res = link.getData(str);
            int rpm = 0;
            try { rpm = Convert.ToInt32(res, 16); }
            catch
            {
                
            }
            txt.AppendText(res + "\n");
            txt.AppendText(rpm + "rpm \n");
        }
    }
}
