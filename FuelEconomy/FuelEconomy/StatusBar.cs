using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    class StatusBar
    {
        private string Status { get; set; }
        private Label imageBar;
        private Label textBar;
        public StatusBar(ref Label imgLabel, ref Label txtLabel)
        {
            imageBar = imgLabel;
            textBar = txtLabel;
        }
        

        public void setStatus(string inputStatus)
        {
            Status = "Статус: " + inputStatus;
            textBar.Text = Status;
            if (Status.Contains("Статус: Подключено"))
                imageBar.Image = global::FuelEconomy.Properties.Resources.Connected;
            else
                imageBar.Image = global::FuelEconomy.Properties.Resources.Disconnected;
        }
    }
}
