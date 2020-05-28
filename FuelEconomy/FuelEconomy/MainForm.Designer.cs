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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.adapterPort = new System.IO.Ports.SerialPort(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainScreen = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.rpmDashboard = new System.Windows.Forms.Label();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.digitDashboardExtension = new System.Windows.Forms.Label();
            this.digitDashboard = new System.Windows.Forms.Label();
            this.statusImageLabel = new System.Windows.Forms.Label();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.settingsScreen = new System.Windows.Forms.TabPage();
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputInjectorPerformance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.mainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.settingsScreen.SuspendLayout();
            this.infoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(104, 478);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(82, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
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
            this.tabControl.Size = new System.Drawing.Size(664, 560);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 8;
            // 
            // mainScreen
            // 
            this.mainScreen.BackColor = System.Drawing.Color.Transparent;
            this.mainScreen.Controls.Add(this.label7);
            this.mainScreen.Controls.Add(this.rpmDashboard);
            this.mainScreen.Controls.Add(this.chartDashboard);
            this.mainScreen.Controls.Add(this.digitDashboardExtension);
            this.mainScreen.Controls.Add(this.digitDashboard);
            this.mainScreen.Controls.Add(this.statusImageLabel);
            this.mainScreen.Controls.Add(this.statusTextLabel);
            this.mainScreen.Controls.Add(this.disconnectButton);
            this.mainScreen.Controls.Add(this.connectButton);
            this.mainScreen.Location = new System.Drawing.Point(130, 4);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Padding = new System.Windows.Forms.Padding(3);
            this.mainScreen.Size = new System.Drawing.Size(530, 552);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.Tag = "";
            this.mainScreen.Text = "Устройство";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "rpm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // rpmDashboard
            // 
            this.rpmDashboard.AutoSize = true;
            this.rpmDashboard.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmDashboard.Location = new System.Drawing.Point(377, 138);
            this.rpmDashboard.Name = "rpmDashboard";
            this.rpmDashboard.Size = new System.Drawing.Size(81, 38);
            this.rpmDashboard.TabIndex = 17;
            this.rpmDashboard.Text = "0000";
            this.rpmDashboard.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.chartDashboard.Size = new System.Drawing.Size(512, 138);
            this.chartDashboard.TabIndex = 16;
            // 
            // digitDashboardExtension
            // 
            this.digitDashboardExtension.AutoSize = true;
            this.digitDashboardExtension.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitDashboardExtension.Location = new System.Drawing.Point(374, 215);
            this.digitDashboardExtension.Name = "digitDashboardExtension";
            this.digitDashboardExtension.Size = new System.Drawing.Size(85, 64);
            this.digitDashboardExtension.TabIndex = 15;
            this.digitDashboardExtension.Text = "l/h";
            // 
            // digitDashboard
            // 
            this.digitDashboard.AutoSize = true;
            this.digitDashboard.Font = new System.Drawing.Font("Old English Text MT", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitDashboard.Location = new System.Drawing.Point(40, 66);
            this.digitDashboard.Name = "digitDashboard";
            this.digitDashboard.Size = new System.Drawing.Size(311, 206);
            this.digitDashboard.TabIndex = 14;
            this.digitDashboard.Text = "0,0";
            this.digitDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusImageLabel
            // 
            this.statusImageLabel.Image = global::FuelEconomy.Properties.Resources.Disconnected;
            this.statusImageLabel.Location = new System.Drawing.Point(3, 3);
            this.statusImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusImageLabel.Name = "statusImageLabel";
            this.statusImageLabel.Size = new System.Drawing.Size(20, 20);
            this.statusImageLabel.TabIndex = 11;
            this.statusImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusTextLabel.Location = new System.Drawing.Point(25, 3);
            this.statusTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(437, 20);
            this.statusTextLabel.TabIndex = 10;
            this.statusTextLabel.Text = "Статус: Отключено";
            this.statusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(323, 478);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(89, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Отключить";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // settingsScreen
            // 
            this.settingsScreen.BackColor = System.Drawing.Color.Transparent;
            this.settingsScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsScreen.Controls.Add(this.buttonDefaultSettings);
            this.settingsScreen.Controls.Add(this.label3);
            this.settingsScreen.Controls.Add(this.inputInjectorPerformance);
            this.settingsScreen.Controls.Add(this.label2);
            this.settingsScreen.Controls.Add(this.label1);
            this.settingsScreen.Controls.Add(this.cbPorts);
            this.settingsScreen.Location = new System.Drawing.Point(130, 4);
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Padding = new System.Windows.Forms.Padding(3);
            this.settingsScreen.Size = new System.Drawing.Size(530, 552);
            this.settingsScreen.TabIndex = 1;
            this.settingsScreen.Text = "Настройки";
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.Location = new System.Drawing.Point(293, 10);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(94, 23);
            this.buttonDefaultSettings.TabIndex = 11;
            this.buttonDefaultSettings.Text = "По умолчанию";
            this.buttonDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonDefaultSettings_Click);
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
            this.inputInjectorPerformance.TextChanged += new System.EventHandler(this.inputInjectorPerformance_TextChanged);
            this.inputInjectorPerformance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputInjectorPerformance_KeyPress);
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
            this.cbPorts.Click += new System.EventHandler(this.cbPorts_Click);
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.label5);
            this.infoPage.Controls.Add(this.label4);
            this.infoPage.Location = new System.Drawing.Point(130, 4);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(530, 552);
            this.infoPage.TabIndex = 2;
            this.infoPage.Text = "Инфо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Для получения данных о мгновенном расходе топлива автомобиля необходимо:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Инструкция пользователя";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(664, 562);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 600);
            this.MinimumSize = new System.Drawing.Size(680, 600);
            this.Name = "MainForm";
            this.Text = "Fuel Economy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.mainScreen.ResumeLayout(false);
            this.mainScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.settingsScreen.ResumeLayout(false);
            this.settingsScreen.PerformLayout();
            this.infoPage.ResumeLayout(false);
            this.infoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort adapterPort;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainScreen;
        private System.Windows.Forms.TabPage settingsScreen;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label statusTextLabel;
        private System.Windows.Forms.Label statusImageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputInjectorPerformance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.Label digitDashboardExtension;
        private System.Windows.Forms.Label digitDashboard;
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rpmDashboard;
    }
}

