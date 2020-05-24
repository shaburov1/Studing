﻿using System;
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
    public partial class MainForm : Form
    {
        private MySettings mySettings;
        private StatusBar statusBar;
        public MainForm()
        {
            InitializeComponent();
            mySettings = new MySettings();
            statusBar = new StatusBar(ref statusImageLabel, ref statusTextLabel);
            if (mySettings.SelectedPort != null)
                connectButton.Enabled = true;
            getCOMports();
            BluetoothSerial.ReadTimeout = 6000;
            BluetoothSerial.NewLine = "\n";
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySettings.saveSettings();
        }

        //***********************************************************************************
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
            mySettings.SelectedPort = cbPorts.SelectedItem.ToString();
            connectButton.Enabled = true;
            mySettings.saveSettings();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!BluetoothSerial.IsOpen)
            {
                BluetoothSerial.PortName = mySettings.SelectedPort;
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
                statusBar.setStatus("Статус: Подключено");
                txt_log.Text += "Подключено к порту: ";
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

        private void btn_disconnect_Click_1(object sender, EventArgs e)
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
    }
}
 