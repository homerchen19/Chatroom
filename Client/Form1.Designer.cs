namespace Client
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblUid = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShake = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sfgDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.txtReceived = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(822, 19);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(133, 32);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "連線";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUid.Location = new System.Drawing.Point(97, 14);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(74, 21);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "尚未連線";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable.Location = new System.Drawing.Point(18, 14);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(73, 21);
            this.lable.TabIndex = 5;
            this.lable.Text = "本機IP：";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMessage.Location = new System.Drawing.Point(13, 314);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(732, 73);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(663, 393);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(82, 27);
            this.btnSendMsg.TabIndex = 5;
            this.btnSendMsg.Text = "傳送訊息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReceived);
            this.groupBox3.Controls.Add(this.btnShake);
            this.groupBox3.Controls.Add(this.btnSendFile);
            this.groupBox3.Controls.Add(this.btnSendMsg);
            this.groupBox3.Controls.Add(this.btnChooseFile);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFilePath);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(210, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 426);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訊息框";
            // 
            // btnShake
            // 
            this.btnShake.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShake.ForeColor = System.Drawing.Color.Red;
            this.btnShake.Location = new System.Drawing.Point(13, 261);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(57, 37);
            this.btnShake.TabIndex = 40;
            this.btnShake.Text = "叮咚";
            this.btnShake.UseVisualStyleBackColor = true;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(578, 393);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(82, 27);
            this.btnSendFile.TabIndex = 36;
            this.btnSendFile.Text = "傳送檔案";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(170, 271);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(68, 23);
            this.btnChooseFile.TabIndex = 34;
            this.btnChooseFile.Text = "選擇檔案";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "檔案路径：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFilePath.Location = new System.Drawing.Point(318, 271);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(427, 23);
            this.txtFilePath.TabIndex = 35;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstFriends);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(-2, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 426);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "客户端列表";
            // 
            // sfgDialog
            // 
            this.sfgDialog.Filter = "所有文件|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有文件|*.*";
            // 
            // lstFriends
            // 
            this.lstFriends.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.ItemHeight = 20;
            this.lstFriends.Location = new System.Drawing.Point(11, 22);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(176, 364);
            this.lstFriends.TabIndex = 0;
            // 
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtReceived.Location = new System.Drawing.Point(15, 22);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(730, 229);
            this.txtReceived.TabIndex = 41;
            this.txtReceived.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 490);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Client";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SaveFileDialog sfgDialog;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.RichTextBox txtReceived;
    }
}

