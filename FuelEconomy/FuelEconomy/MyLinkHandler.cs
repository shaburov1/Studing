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

        public string getData(string request)
        {
            try
            {
                if (request.Length != 0)
                {
                    linkPort.WriteLine(request);
                }
            }
            catch
            {
                return "";
            }
            string res = "";
            getAnswer(ref res, 3000);
            if (res.Length < 4)
                return "";
            res = res.Replace(" ", "");

            request = request.Replace("01", "41");
            request = request.Trim();

            if (res.Contains(request))
                res = res.Replace(request, "");
            res = res.Replace(">", "");
            res = res.Trim();
            return res;
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
        public void getAnswer(ref string str, int timeout = 1000)
        {
            linkPort.ReadTimeout = timeout;
            timerFlag = true;
            str = "";
            listenTimer = new System.Timers.Timer(timeout);
            listenTimer.Elapsed += Timer_Elapsed;
            listenTimer.Start();
            while (timerFlag)
            {
                try {str += linkPort.ReadExisting();}
                catch { break; }
                if (str.Contains(">"))
                    break;
            }
            listenTimer.Stop();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerFlag = false;
        }
    }
}
