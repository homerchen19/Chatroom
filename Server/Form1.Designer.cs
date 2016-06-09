namespace Server
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        // 清理所有正在使用的資源
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.txtServerState = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShankAll = new System.Windows.Forms.Button();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboMaxCount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNowCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelJY = new System.Windows.Forms.Button();
            this.btnJY = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Location = new System.Drawing.Point(8, 353);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(76, 33);
            this.btnBeginListen.TabIndex = 0;
            this.btnBeginListen.Text = "開啟";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // txtServerState
            // 
            this.txtServerState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerState.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtServerState.Location = new System.Drawing.Point(3, 19);
            this.txtServerState.Multiline = true;
            this.txtServerState.Name = "txtServerState";
            this.txtServerState.Size = new System.Drawing.Size(531, 276);
            this.txtServerState.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServerState);
            this.groupBox2.Location = new System.Drawing.Point(227, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 298);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户聊天訊息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstClient);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 371);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用戶列表";
            // 
            // lstClient
            // 
            this.lstClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClient.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 24;
            this.lstClient.Location = new System.Drawing.Point(3, 19);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(209, 349);
            this.lstClient.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShankAll);
            this.groupBox4.Controls.Add(this.btnSendAll);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.txtSend);
            this.groupBox4.Location = new System.Drawing.Point(227, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 113);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "傳送訊息给用戶";
            // 
            // btnShankAll
            // 
            this.btnShankAll.Location = new System.Drawing.Point(309, 70);
            this.btnShankAll.Name = "btnShankAll";
            this.btnShankAll.Size = new System.Drawing.Size(71, 37);
            this.btnShankAll.TabIndex = 9;
            this.btnShankAll.Text = "全體叮咚";
            this.btnShankAll.UseVisualStyleBackColor = true;
            this.btnShankAll.Click += new System.EventHandler(this.btnShankAll_Click);
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(456, 70);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(75, 37);
            this.btnSendAll.TabIndex = 8;
            this.btnSendAll.Text = "全體傳送";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(386, 70);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "傳送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(3, 19);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(528, 45);
            this.txtSend.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 455);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveLog);
            this.tabPage1.Controls.Add(this.btnClearLog);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnPause);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.btnBeginListen);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "伺服器管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(676, 392);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 33);
            this.btnSaveLog.TabIndex = 16;
            this.btnSaveLog.Text = "儲存";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(595, 392);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 33);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "清除";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLog);
            this.groupBox5.Location = new System.Drawing.Point(180, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(589, 381);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLog.Location = new System.Drawing.Point(16, 15);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(555, 353);
            this.txtLog.TabIndex = 0;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(90, 353);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(84, 33);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboMaxCount);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtNowCount);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtSerPort);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtSerIP);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtSerName);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtStatu);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 341);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "伺服器訊息";
            // 
            // cboMaxCount
            // 
            this.cboMaxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxCount.FormattingEnabled = true;
            this.cboMaxCount.Items.AddRange(new object[] {
            "100",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.cboMaxCount.Location = new System.Drawing.Point(9, 292);
            this.cboMaxCount.Name = "cboMaxCount";
            this.cboMaxCount.Size = new System.Drawing.Size(140, 24);
            this.cboMaxCount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "最大連線數量限制";
            // 
            // txtNowCount
            // 
            this.txtNowCount.Location = new System.Drawing.Point(9, 240);
            this.txtNowCount.Name = "txtNowCount";
            this.txtNowCount.Size = new System.Drawing.Size(140, 23);
            this.txtNowCount.TabIndex = 11;
            this.txtNowCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "目前連線數量";
            // 
            // txtSerPort
            // 
            this.txtSerPort.Location = new System.Drawing.Point(9, 188);
            this.txtSerPort.Name = "txtSerPort";
            this.txtSerPort.Size = new System.Drawing.Size(140, 23);
            this.txtSerPort.TabIndex = 7;
            this.txtSerPort.Text = "5555";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "port";
            // 
            // txtSerIP
            // 
            this.txtSerIP.Location = new System.Drawing.Point(9, 139);
            this.txtSerIP.Name = "txtSerIP";
            this.txtSerIP.Size = new System.Drawing.Size(140, 23);
            this.txtSerIP.TabIndex = 5;
            this.txtSerIP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "伺服器IP";
            // 
            // txtSerName
            // 
            this.txtSerName.Location = new System.Drawing.Point(9, 88);
            this.txtSerName.Name = "txtSerName";
            this.txtSerName.Size = new System.Drawing.Size(140, 23);
            this.txtSerName.TabIndex = 3;
            this.txtSerName.Text = "ServerPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "伺服器名稱";
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(9, 37);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.Size = new System.Drawing.Size(140, 23);
            this.txtStatu.TabIndex = 1;
            this.txtStatu.Text = "停止";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "狀態";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelJY);
            this.tabPage2.Controls.Add(this.btnJY);
            this.tabPage2.Controls.Add(this.btnTR);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelJY
            // 
            this.btnCancelJY.Location = new System.Drawing.Point(157, 383);
            this.btnCancelJY.Name = "btnCancelJY";
            this.btnCancelJY.Size = new System.Drawing.Size(61, 34);
            this.btnCancelJY.TabIndex = 11;
            this.btnCancelJY.Text = "解禁";
            this.btnCancelJY.UseVisualStyleBackColor = true;
            this.btnCancelJY.Click += new System.EventHandler(this.btnCancelJY_Click);
            // 
            // btnJY
            // 
            this.btnJY.Location = new System.Drawing.Point(76, 383);
            this.btnJY.Name = "btnJY";
            this.btnJY.Size = new System.Drawing.Size(75, 34);
            this.btnJY.TabIndex = 10;
            this.btnJY.Text = "禁言";
            this.btnJY.UseVisualStyleBackColor = true;
            this.btnJY.Click += new System.EventHandler(this.btnJY_Click);
            // 
            // btnTR
            // 
            this.btnTR.Location = new System.Drawing.Point(9, 383);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(61, 34);
            this.btnTR.TabIndex = 9;
            this.btnTR.Text = "踢人";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "log.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 455);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.TextBox txtServerState;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnJY;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cboMaxCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNowCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSerPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelJY;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnShankAll;
    }
}

