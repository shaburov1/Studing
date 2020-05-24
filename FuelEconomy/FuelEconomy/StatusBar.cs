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
        private Label image;
        private Label text;
        public StatusBar(ref Label img, ref Label txt)
        {
            image = img;
            text = txt;
        }
        

        public void setStatus(string status)
        {
            Status = status;
            text.Text = Status;
            if (Status == "Статус: Подключено")
                image.Image = global::FuelEconomy.Properties.Resources.Connected;
            else
                image.Image = global::FuelEconomy.Properties.Resources.Disconnected;
        }
    }
}
