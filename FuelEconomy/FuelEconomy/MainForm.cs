using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuelEconomy
{
    public partial class MainForm : Form
    {
        private MySettings mySettings;
        private StatusBar statusBar;
        private RemoteDevice remoteScanner;
        private ChartDashboard chartDash;
        public MainForm()
        {
            InitializeComponent();
            getCOMports();
            mySettings = new MySettings(ref connectButton, ref cbPorts, ref inputInjectorPerformance);
            statusBar = new StatusBar(ref statusImageLabel, ref statusTextLabel);
            chartDash = new ChartDashboard(ref chartDashboard);
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            MainForm.CheckForIllegalCrossThreadCalls = false;
        }

        /**
         * Настройка отрисовки стиля вкладок
         */
        private void tabControl_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Получим объект из коллекции
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Получим параметры ограничивающей рамки.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            //используем другой шрифт
            Font _tabFont;

            if (e.State == DrawItemState.Selected)
            {
                //Изменим шрифт и закрасим фон
                _tabFont = new Font("Comic Sans MS", 18.0f, FontStyle.Bold, GraphicsUnit.Pixel);
                g.FillRectangle(Brushes.AliceBlue, e.Bounds);
                _textBrush = new System.Drawing.SolidBrush(Color.Blue);
            }
            else
            {
                _tabFont = new Font("Comic Sans MS", 18.0f, FontStyle.Regular, GraphicsUnit.Pixel);
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Напечатаем название вкладки по центру
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mySettings.loadSettings();
        }
        private void inputInjectorPerformance_TextChanged(object sender, EventArgs e)
        {
            UInt32 value;
            if (UInt32.TryParse(inputInjectorPerformance.Text, out value))
                mySettings.InjectorPerformance = value;
            else
                inputInjectorPerformance.Text = "0";
        }
        private void inputInjectorPerformance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void buttonDefaultSettings_Click(object sender, EventArgs e)
        {
            mySettings.setSettingsToDefault();
        }
        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPorts.SelectedItem != null)
                mySettings.SelectedPort = cbPorts.SelectedItem.ToString();
            else
                cbPorts.Text = "Не выбрано";
        }
        private void cbPorts_Click(object sender, EventArgs e)
        {
            List<string> COMlist = getCOMports();
            cbPorts.Items.Clear();
            cbPorts.Text = "Выберите порт";
            cbPorts.Items.AddRange(COMlist.ToArray());
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            remoteScanner = new RemoteDevice(ref BluetoothSerial, ref statusBar);
            remoteScanner.connect(mySettings.SelectedPort);
            if (remoteScanner.init())
                txt_log.AppendText("ljahalkodf");
        }
        static public List<string> getCOMports()
        {
            string[] ports = SerialPort.GetPortNames();
            List<string> uniqPorts = new List<string>();
            foreach (var m in ports.Distinct<string>())
            {
                uniqPorts.Add(m);
            }
            return uniqPorts;
        }
        //***********************************************************************************


        private void btn_send_Click(object sender, EventArgs e)
        {
            string str = "";
            if (txt_to_send.TextLength != 0)
            {
                str = txt_to_send.Text + "\r";
                remoteScanner.getData(str, ref txt_log);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_log.Clear();
        }

        private void btn_rcv_Click(object sender, EventArgs e)
        {
            //string s = "";
            //rcvMsg(ref s);
            //txt_log.AppendText(s);
            chartDash.addNextparam(0.8);
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

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (BluetoothSerial.IsOpen)
                BluetoothSerial.Close();

            if (!BluetoothSerial.IsOpen)
            {
                statusBar.setStatus("Отключено");
                txt_log.Text += "Отключено от порта: ";
                txt_log.Text += BluetoothSerial.PortName;
                txt_log.AppendText("\r\n");
            }
        }

        private void startchart_Click(object sender, EventArgs e)
        {
            chartDash.startChart();
        }
    }
}
