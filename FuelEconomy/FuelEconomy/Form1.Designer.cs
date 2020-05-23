namespace FuelEconomy
{
    partial class Form1
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
            this.BluetoothSerial = new System.IO.Ports.SerialPort(this.components);
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_to_send = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_rcv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BluetoothSerial
            // 
            this.BluetoothSerial.PortName = "COM3";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_to_send
            // 
            this.txt_to_send.Location = new System.Drawing.Point(115, 14);
            this.txt_to_send.Name = "txt_to_send";
            this.txt_to_send.Size = new System.Drawing.Size(181, 20);
            this.txt_to_send.TabIndex = 1;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(485, 43);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(337, 269);
            this.txt_log.TabIndex = 2;
            this.txt_log.TextChanged += new System.EventHandler(this.txt_log_TextChanged);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(12, 50);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(101, 21);
            this.cbPorts.TabIndex = 3;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(119, 50);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(82, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Подключить";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(207, 50);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(89, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Отключить";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(752, 14);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_rcv
            // 
            this.btn_rcv.Location = new System.Drawing.Point(93, 12);
            this.btn_rcv.Name = "btn_rcv";
            this.btn_rcv.Size = new System.Drawing.Size(16, 23);
            this.btn_rcv.TabIndex = 7;
            this.btn_rcv.UseVisualStyleBackColor = true;
            this.btn_rcv.Click += new System.EventHandler(this.btn_rcv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btn_rcv);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_to_send);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort BluetoothSerial;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_to_send;
        protected System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_rcv;
    }
}

