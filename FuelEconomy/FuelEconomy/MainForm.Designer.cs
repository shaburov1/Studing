namespace FuelEconomy
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BluetoothSerial = new System.IO.Ports.SerialPort(this.components);
            this.txt_to_send = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_rcv = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainScreen = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStatusImage = new System.Windows.Forms.Label();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.settingsScreen = new System.Windows.Forms.TabPage();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.mainScreen.SuspendLayout();
            this.settingsScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // BluetoothSerial
            // 
            this.BluetoothSerial.PortName = "COM3";
            // 
            // txt_to_send
            // 
            this.txt_to_send.Location = new System.Drawing.Point(467, 165);
            this.txt_to_send.Name = "txt_to_send";
            this.txt_to_send.Size = new System.Drawing.Size(181, 20);
            this.txt_to_send.TabIndex = 1;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(374, 243);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(274, 210);
            this.txt_log.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(60, 430);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(82, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Подключить";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(578, 205);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_rcv
            // 
            this.btn_rcv.Location = new System.Drawing.Point(467, 125);
            this.btn_rcv.Name = "btn_rcv";
            this.btn_rcv.Size = new System.Drawing.Size(71, 23);
            this.btn_rcv.TabIndex = 7;
            this.btn_rcv.Text = "Принять";
            this.btn_rcv.UseVisualStyleBackColor = true;
            this.btn_rcv.Click += new System.EventHandler(this.btn_rcv_Click);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.mainScreen);
            this.tabControl.Controls.Add(this.settingsScreen);
            this.tabControl.Controls.Add(this.infoPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(40, 120);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 560);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 8;
            // 
            // mainScreen
            // 
            this.mainScreen.BackColor = System.Drawing.Color.Transparent;
            this.mainScreen.Controls.Add(this.button2);
            this.mainScreen.Controls.Add(this.button1);
            this.mainScreen.Controls.Add(this.labelStatusImage);
            this.mainScreen.Controls.Add(this.labelStatusText);
            this.mainScreen.Controls.Add(this.btn_send);
            this.mainScreen.Controls.Add(this.btn_disconnect);
            this.mainScreen.Controls.Add(this.btn_connect);
            this.mainScreen.Controls.Add(this.btn_clear);
            this.mainScreen.Controls.Add(this.btn_rcv);
            this.mainScreen.Controls.Add(this.txt_log);
            this.mainScreen.Controls.Add(this.txt_to_send);
            this.mainScreen.Location = new System.Drawing.Point(130, 4);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Padding = new System.Windows.Forms.Padding(3);
            this.mainScreen.Size = new System.Drawing.Size(650, 552);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.Tag = "";
            this.mainScreen.Text = "Устройство";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStatusImage
            // 
            this.labelStatusImage.Image = global::FuelEconomy.Properties.Resources.Disconnected;
            this.labelStatusImage.Location = new System.Drawing.Point(3, 3);
            this.labelStatusImage.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusImage.Name = "labelStatusImage";
            this.labelStatusImage.Size = new System.Drawing.Size(20, 20);
            this.labelStatusImage.TabIndex = 11;
            this.labelStatusImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatusText
            // 
            this.labelStatusText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatusText.Location = new System.Drawing.Point(23, 3);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(300, 20);
            this.labelStatusText.TabIndex = 10;
            this.labelStatusText.Text = "Статус: Отключено";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(573, 125);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(200, 430);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(89, 23);
            this.btn_disconnect.TabIndex = 9;
            this.btn_disconnect.Text = "Отключить";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click_1);
            // 
            // settingsScreen
            // 
            this.settingsScreen.BackColor = System.Drawing.Color.Transparent;
            this.settingsScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsScreen.Controls.Add(this.cbPorts);
            this.settingsScreen.Location = new System.Drawing.Point(130, 4);
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Padding = new System.Windows.Forms.Padding(3);
            this.settingsScreen.Size = new System.Drawing.Size(650, 552);
            this.settingsScreen.TabIndex = 1;
            this.settingsScreen.Text = "Настройки";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(28, 23);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(122, 21);
            this.cbPorts.TabIndex = 6;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // infoPage
            // 
            this.infoPage.Location = new System.Drawing.Point(130, 4);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(650, 552);
            this.infoPage.TabIndex = 2;
            this.infoPage.Text = "Инфо";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Fuel Economy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.mainScreen.ResumeLayout(false);
            this.mainScreen.PerformLayout();
            this.settingsScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort BluetoothSerial;
        private System.Windows.Forms.TextBox txt_to_send;
        protected System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_rcv;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainScreen;
        private System.Windows.Forms.TabPage settingsScreen;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatusImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

