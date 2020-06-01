using System;
using System.Windows.Forms;

namespace FuelEconomy
{
    class StatusBar
    {
        private string status;
        private string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = "Статус: " + value;
                if (status.Contains("Статус: Подключено"))
                    imageBar.Image = global::FuelEconomy.Properties.Resources.Connected;
                else
                    imageBar.Image = global::FuelEconomy.Properties.Resources.Disconnected;
            }

        }
        private Label imageBar;
        private Label textBar;
        public StatusBar(ref Label imgLabel, ref Label txtLabel)
        {
            imageBar = imgLabel;
            textBar = txtLabel;
        }

        private void setStatusDirectly(string inputStatus)
        {
            Status = inputStatus;
            textBar.Text = Status;
        }

        public void setStatus(string s)
        {
            textBar.Invoke(new Action<String>(setStatusDirectly), s);
        }
    }
}
