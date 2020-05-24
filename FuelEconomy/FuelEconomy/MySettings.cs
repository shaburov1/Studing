using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    class MySettings
    {
        private string selectedPort = null;
        private UInt32 injectorPerformance = 0;
        private Button connectButton = null;

        public MySettings(ref Button connBut)
        {
            connectButton = connBut;
        }
        public string SelectedPort
        {
            get
            {
                return selectedPort;
            }
            set
            {                    
                selectedPort = value;
                if (selectedPort != null)
                    connectButton.Enabled = true;
                else
                    connectButton.Enabled = false;
                saveSettings();
            }
        }

        public UInt32 InjectorPerformance
        {
            get
            {
                return injectorPerformance;
            }
            set
            {
                injectorPerformance = value;
                saveSettings();
            }
        }

        public void loadSettings()
        {
            List<string> ports = MainForm.getCOMports();
            if (ports.Contains(Properties.Settings.Default.lastPort))
                SelectedPort = Properties.Settings.Default.lastPort;
            else
                SelectedPort = null;

            InjectorPerformance = Properties.Settings.Default.injectorPerformance;
        }

        public void saveSettings()
        {
            Properties.Settings.Default.lastPort = SelectedPort;
            Properties.Settings.Default.injectorPerformance = InjectorPerformance;
        }

        public void setSettingsToDefault()
        {
            this.SelectedPort = null;
            this.InjectorPerformance = 0;
        }
    }
}
