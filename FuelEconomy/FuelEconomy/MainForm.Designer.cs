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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0.8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1.2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 9D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0.8D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BluetoothSerial = new System.IO.Ports.SerialPort(this.components);
            this.txt_to_send = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_rcv = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainScreen = new System.Windows.Forms.TabPage();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.digitDashboardExtension = new System.Windows.Forms.Label();
            this.digitDashboard = new System.Windows.Forms.Label();
            this.statusImageLabel = new System.Windows.Forms.Label();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.settingsScreen = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.inputInjectorPerformance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.mainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.settingsScreen.SuspendLayout();
            this.SuspendLayout();
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
            this.txt_log.Location = new System.Drawing.Point(332, 453);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(310, 93);
            this.txt_log.TabIndex = 2;
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(60, 523);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(82, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.btn_connect_Click);
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
            this.mainScreen.Controls.Add(this.chartDashboard);
            this.mainScreen.Controls.Add(this.digitDashboardExtension);
            this.mainScreen.Controls.Add(this.digitDashboard);
            this.mainScreen.Controls.Add(this.statusImageLabel);
            this.mainScreen.Controls.Add(this.statusTextLabel);
            this.mainScreen.Controls.Add(this.btn_send);
            this.mainScreen.Controls.Add(this.btn_disconnect);
            this.mainScreen.Controls.Add(this.connectButton);
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
            // chartDashboard
            // 
            this.chartDashboard.BackColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 11D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.Y = 5F;
            this.chartDashboard.ChartAreas.Add(chartArea1);
            this.chartDashboard.Location = new System.Drawing.Point(26, 291);
            this.chartDashboard.Name = "chartDashboard";
            this.chartDashboard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.CornflowerBlue;
            series1.CustomProperties = "PointWidth=0.6";
            series1.EmptyPointStyle.Color = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.LabelBackColor = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.MarkerColor = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.MarkerSize = 3;
            series1.Name = "chartData";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDashboard.Series.Add(series1);
            this.chartDashboard.Size = new System.Drawing.Size(512, 138);
            this.chartDashboard.TabIndex = 16;
            // 
            // digitDashboardExtension
            // 
            this.digitDashboardExtension.AutoSize = true;
            this.digitDashboardExtension.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitDashboardExtension.Location = new System.Drawing.Point(374, 215);
            this.digitDashboardExtension.Name = "digitDashboardExtension";
            this.digitDashboardExtension.Size = new System.Drawing.Size(88, 57);
            this.digitDashboardExtension.TabIndex = 15;
            this.digitDashboardExtension.Text = "l/h";
            // 
            // digitDashboard
            // 
            this.digitDashboard.AutoSize = true;
            this.digitDashboard.Font = new System.Drawing.Font("Old English Text MT", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitDashboard.Location = new System.Drawing.Point(57, 66);
            this.digitDashboard.Name = "digitDashboard";
            this.digitDashboard.Size = new System.Drawing.Size(311, 206);
            this.digitDashboard.TabIndex = 14;
            this.digitDashboard.Text = "0,0";
            // 
            // labelStatusImage
            // 
            this.statusImageLabel.Image = global::FuelEconomy.Properties.Resources.Disconnected;
            this.statusImageLabel.Location = new System.Drawing.Point(3, 3);
            this.statusImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusImageLabel.Name = "labelStatusImage";
            this.statusImageLabel.Size = new System.Drawing.Size(20, 20);
            this.statusImageLabel.TabIndex = 11;
            this.statusImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatusText
            // 
            this.statusTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusTextLabel.Location = new System.Drawing.Point(23, 3);
            this.statusTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusTextLabel.Name = "labelStatusText";
            this.statusTextLabel.Size = new System.Drawing.Size(300, 20);
            this.statusTextLabel.TabIndex = 10;
            this.statusTextLabel.Text = "Статус: Отключено";
            this.statusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_disconnect.Location = new System.Drawing.Point(200, 523);
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
            this.settingsScreen.Controls.Add(this.label3);
            this.settingsScreen.Controls.Add(this.inputInjectorPerformance);
            this.settingsScreen.Controls.Add(this.label2);
            this.settingsScreen.Controls.Add(this.label1);
            this.settingsScreen.Controls.Add(this.cbPorts);
            this.settingsScreen.Location = new System.Drawing.Point(130, 4);
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Padding = new System.Windows.Forms.Padding(3);
            this.settingsScreen.Size = new System.Drawing.Size(650, 552);
            this.settingsScreen.TabIndex = 1;
            this.settingsScreen.Text = "Настройки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "cc/min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputInjectorPerformance
            // 
            this.inputInjectorPerformance.Location = new System.Drawing.Point(24, 111);
            this.inputInjectorPerformance.Margin = new System.Windows.Forms.Padding(10);
            this.inputInjectorPerformance.MaxLength = 4;
            this.inputInjectorPerformance.Name = "inputInjectorPerformance";
            this.inputInjectorPerformance.Size = new System.Drawing.Size(44, 20);
            this.inputInjectorPerformance.TabIndex = 9;
            this.inputInjectorPerformance.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Рассчетная производительность форсунок";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Порт к которому подключено устройство";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(24, 45);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(101, 21);
            this.cbPorts.TabIndex = 6;
            this.cbPorts.Text = "Не выбран";
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
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.settingsScreen.ResumeLayout(false);
            this.settingsScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort BluetoothSerial;
        private System.Windows.Forms.TextBox txt_to_send;
        protected System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_rcv;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainScreen;
        private System.Windows.Forms.TabPage settingsScreen;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_disconnect;
        protected System.Windows.Forms.Label statusTextLabel;
        protected System.Windows.Forms.Label statusImageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputInjectorPerformance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.Label digitDashboardExtension;
        private System.Windows.Forms.Label digitDashboard;
    }
}

