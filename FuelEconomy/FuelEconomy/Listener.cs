using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEconomy
{
    class Listener
    {
        private SerialPort listenPort = null;
        private System.Timers.Timer timer;
        private bool timerFlag = true;
        public Listener(ref SerialPort port)
        {
            listenPort = port;
        }

        internal void getAnswer(ref string str, int timeout = 1000)
        {
            listenPort.ReadTimeout = timeout;
            timerFlag = true;
            str = "";
            timer = new System.Timers.Timer(timeout);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            while (timerFlag)
            {
                str += listenPort.ReadExisting();
            }
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerFlag = false;
        }
    }
}
