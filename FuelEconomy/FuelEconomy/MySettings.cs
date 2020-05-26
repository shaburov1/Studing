using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FuelEconomy
{
    class MySettings
    {
        private string selectedPort = null;
        private UInt32 injectorPerformance = 0;
        private Button connectButton = null;
        private ComboBox cbPorts = null;
        private TextBox injPerformanceTextBox = null;

        public MySettings(ref Button connBut, ref ComboBox cb, ref TextBox tb)
        {
            connectButton = connBut;
            cbPorts = cb;
            injPerformanceTextBox = tb;           
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
                {
                    cbPorts.Text = "Не выбрано";
                    connectButton.Enabled = false;
                }
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
            injectorPerformance = Properties.Settings.Default.injectorPerformance;

            List<string> ports = MainForm.getCOMports();
            if (ports.Contains(Properties.Settings.Default.linkPort))
                SelectedPort = Properties.Settings.Default.linkPort;
            else
                SelectedPort = null;
            
            cbPorts.Text = SelectedPort == null ? "Не выбрано" : SelectedPort;
            cbPorts.SelectedItem = SelectedPort == null ? "Не выбрано" : SelectedPort;
            injPerformanceTextBox.Text = InjectorPerformance.ToString();
        }

        public void saveSettings()
        {
            Properties.Settings.Default.linkPort = SelectedPort;
            Properties.Settings.Default.injectorPerformance = InjectorPerformance;
            Properties.Settings.Default.Save();
        }

        public void setSettingsToDefault()
        {
            SelectedPort = null;
            InjectorPerformance = 0;

            cbPorts.SelectedItem = SelectedPort;
            injPerformanceTextBox.Text = "0";
        }
    }
}
