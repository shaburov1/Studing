using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEconomy
{
    class Sender
    {
        private SerialPort senderPort = null;

        public Sender(ref SerialPort port)
        {
            senderPort = port;
        }

        public bool send(string str)
        {
            try
            {
                if (str.Length != 0)
                {
                    str += "\r";
                    senderPort.WriteLine(str);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
