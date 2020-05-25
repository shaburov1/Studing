using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            port.ReadTimeout = 3000;
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
                if (verify())
                    statusBar.setStatus($"Подключено к порту {port.PortName}");
                else
                    statusBar.setStatus("Ошибка, устройство не прошло проверку");
            }

        }

        private bool verify()
        {
            if(!link.send("atz"))
                return false;
            string str = "";
            link.getAnswer(ref str, 1000);
            if(str.Contains("ELM327 v1.5"))
                return true;
            else
                return false;
        }
    }
}
