using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuelEconomy
{
    public partial class MainForm : Form
    {
        private MySettings mySettings;
        private StatusBar statusBar;
        private RemoteDevice remoteScaner;
        private Dashboard dashboard;
        Task taskConnecting = null;
        public MainForm()
        {
            InitializeComponent();
            mySettings = new MySettings(ref connectButton, ref cbPorts, ref inputInjectorPerformance);
            statusBar = new StatusBar(ref statusImageLabel, ref statusTextLabel);
            dashboard = new Dashboard(ref chartDashboard, ref digitDashboard, ref rpmDashboard);
            remoteScaner = new RemoteDevice(ref adapterPort, ref statusBar, ref dashboard, ref mySettings);
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            MainForm.CheckForIllegalCrossThreadCalls = true;
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
            taskConnecting = Task.Run(connectRemoteDev);
        }

        private void connectRemoteDev()
        {
            statusBar.setStatus("Подключение.");
            if(!remoteScaner.connect(mySettings.SelectedPort))
                return;
            if (!remoteScaner.init())
                return;
            dashboard.startChartWork();
            remoteScaner.startWork();
        }

        private void disconnectRemoteDev() 
        {
            statusBar.setStatus("Отключение");
            if (taskConnecting != null)
               taskConnecting.Wait();
            dashboard.stopChartWork();
            remoteScaner.stopWork();
            remoteScaner.disconnect();
        }
        async private void disconnectButton_Click(object sender, EventArgs e)
        {
            await Task.Run(disconnectRemoteDev);
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

        async private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Task.Run(disconnectRemoteDev);
        }
    }
}
