using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEconomy
{
    class MySettings
    {
        public string SelectedPort { get; set; }
        public UInt32 InjectorPerformance { get; set; }

        public void loadSettings()
        {
            SelectedPort = Properties.Settings.Default.lastPort;
        }

        public void saveSettings()
        {
            Properties.Settings.Default.lastPort = SelectedPort;
        }
    }
}
