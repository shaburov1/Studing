using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEconomy
{
    class MyLinkHandler
    {
        private SerialPort linkPort = null;
        private System.Timers.Timer listenTimer;
        private bool timerFlag = true;

        public MyLinkHandler(ref SerialPort port)
        {
            linkPort = port;
        }

        public bool send(string str)
        {
            try
            {
                if (str.Length != 0)
                {
                    str += "\r";
                    linkPort.WriteLine(str);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        internal void getAnswer(ref string str, int timeout = 1000)
        {
            linkPort.ReadTimeout = timeout;
            timerFlag = true;
            str = "";
            listenTimer = new System.Timers.Timer(timeout);
            listenTimer.Elapsed += Timer_Elapsed;
            listenTimer.Start();
            while (timerFlag)
            {
                str += linkPort.ReadExisting();
            }
            listenTimer.Stop();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerFlag = false;
        }
    }
}
