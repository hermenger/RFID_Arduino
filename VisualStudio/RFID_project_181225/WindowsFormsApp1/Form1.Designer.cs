namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btSaveToDB = new System.Windows.Forms.Button();
            this.btCLRlog = new System.Windows.Forms.Button();
            this.tbCOMnum = new System.Windows.Forms.TextBox();
            this.tbRFIDlabel = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.LogMsg = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSaveToDB
            // 
            this.btSaveToDB.Location = new System.Drawing.Point(12, 104);
            this.btSaveToDB.Name = "btSaveToDB";
            this.btSaveToDB.Size = new System.Drawing.Size(75, 81);
            this.btSaveToDB.TabIndex = 0;
            this.btSaveToDB.Text = "送出";
            this.btSaveToDB.UseVisualStyleBackColor = true;
            this.btSaveToDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCLRlog
            // 
            this.btCLRlog.Location = new System.Drawing.Point(104, 104);
            this.btCLRlog.Name = "btCLRlog";
            this.btCLRlog.Size = new System.Drawing.Size(75, 79);
            this.btCLRlog.TabIndex = 1;
            this.btCLRlog.Text = "查詢";
            this.btCLRlog.UseVisualStyleBackColor = true;
            this.btCLRlog.Click += new System.EventHandler(this.btCLRlog_Click);
            // 
            // tbCOMnum
            // 
            this.tbCOMnum.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbCOMnum.Location = new System.Drawing.Point(79, 18);
            this.tbCOMnum.Name = "tbCOMnum";
            this.tbCOMnum.Size = new System.Drawing.Size(100, 22);
            this.tbCOMnum.TabIndex = 2;
            this.tbCOMnum.Text = "COM3";
            this.tbCOMnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbRFIDlabel
            // 
            this.tbRFIDlabel.Location = new System.Drawing.Point(79, 46);
            this.tbRFIDlabel.Name = "tbRFIDlabel";
            this.tbRFIDlabel.Size = new System.Drawing.Size(100, 22);
            this.tbRFIDlabel.TabIndex = 3;
            this.tbRFIDlabel.TextChanged += new System.EventHandler(this.tbRFIDlabel_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 250);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // LogMsg
            // 
            this.LogMsg.Location = new System.Drawing.Point(355, 22);
            this.LogMsg.Multiline = true;
            this.LogMsg.Name = "LogMsg";
            this.LogMsg.ReadOnly = true;
            this.LogMsg.Size = new System.Drawing.Size(317, 163);
            this.LogMsg.TabIndex = 5;
            this.LogMsg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "COMport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "RFID_Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserName";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "開啟Arduino Serial Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "關閉Arduino Serial Port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Serial Port測試";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Save Log";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(185, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Auto Mode: On";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Auto Mode: Off";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 249);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Log";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 445);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.LogMsg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbRFIDlabel);
            this.Controls.Add(this.tbCOMnum);
            this.Controls.Add(this.btCLRlog);
            this.Controls.Add(this.btSaveToDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "國立宜蘭大學多媒體網路通訊數位學習碩士在職專班_10701_RFID_期末專題_n0743009_n0743015";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSaveToDB;
        private System.Windows.Forms.Button btCLRlog;
        private System.Windows.Forms.TextBox tbCOMnum;
        private System.Windows.Forms.TextBox tbRFIDlabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox LogMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

