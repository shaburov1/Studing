using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        private string SelectedPort { get; set; }
        public Form1()
        {
            InitializeComponent();
            getCOMports();
            BluetoothSerial.ReadTimeout = 6000;
            BluetoothSerial.NewLine = "\n";
        }

        private void getCOMports()
        {
            string[] ports = SerialPort.GetPortNames();
            List<string> uniqPorts = new List<string>();
            foreach (var m in ports.Distinct<string>())
            {
                uniqPorts.Add(m);
            }
            cbPorts.Items.Clear();
            cbPorts.Text = "Выберите порт";
            cbPorts.Items.AddRange(uniqPorts.ToArray());
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string str = "";
            if (txt_to_send.TextLength != 0)
            {
                str = txt_to_send.Text + "\r";
                BluetoothSerial.WriteLine(str);
            }
            txt_log.Text += "Отправлено: "  + str.Length + " байт" + "\r\n";
            txt_log.Text += txt_to_send.Text;
            txt_log.AppendText("\r\n");

            Thread listenPort = new Thread(listenCOMPort);
            listenPort.Start();
            //Thread.Sleep(500);
            //byte[] buff = new byte[256];
            //int rcvMsgCount = BluetoothSerial.Read(buff, 0, BluetoothSerial.BytesToRead);
            //str = "Получено: " + rcvMsgCount + " байт";
            //str += "\r\n";
            //for (int i = 0; i < rcvMsgCount; ++i)
            //{
            //    str += (char)buff[i];
            //    if ((char)buff[i] == 0x0D)
            //        str += "\n";
            //}
            //txt_log.AppendText(str + "\r\n");
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPort = cbPorts.SelectedItem.ToString();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!BluetoothSerial.IsOpen)
            {
                BluetoothSerial.PortName = SelectedPort;
            }
            else
            {
                txt_log.Text += "Порт ";
                txt_log.Text += BluetoothSerial.PortName + " уже открыт, необходимо отключиться от порта";
                txt_log.AppendText("\r\n");
                return;
            }
            try { BluetoothSerial.Open(); }
            catch 
            {
                txt_log.AppendText("Ошибка, подключение к порту невозможно \r\n");
                return;
            }
            
            
            if (BluetoothSerial.IsOpen)
            {
                txt_log.Text += "Подключено к порту: ";
                txt_log.Text += BluetoothSerial.PortName;
                txt_log.AppendText("\r\n");
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (BluetoothSerial.IsOpen)
                BluetoothSerial.Close();

            if (!BluetoothSerial.IsOpen)
            {
                txt_log.Text += "Отключено от порта: ";
                txt_log.Text += BluetoothSerial.PortName;
                txt_log.AppendText("\r\n");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_log.Clear();
        }

        private void btn_rcv_Click(object sender, EventArgs e)
        {
            string s = "";
            rcvMsg(ref s);
            txt_log.AppendText(s);
        }
        private void rcvMsg(ref string S)
        {
            if (BluetoothSerial.BytesToRead != 0)
            {
                string s = "";
                while (BluetoothSerial.BytesToRead != 0)
                {
                    char c = (char)BluetoothSerial.ReadByte();
                    if (s.Length != 0 && s.Last<char>() == 0x0D && c == 0x0D)
                        s += "\n";
                    s += c;
                }
                S += (s + "\r\n");
            }
        }

        private void listenCOMPort()
        {
            string s = "";

            for (int i = 0; i < 30; i++)
            {
                rcvMsg(ref s);
                Thread.Sleep(100);
            }
            //txt_log.AppendText(s);
        }

        private void txt_log_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 