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
            this.lable = new System.Windows.Forms.Label();
            this.sfgDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(618, 14);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(133, 32);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "連線";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable.Location = new System.Drawing.Point(17, 14);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(58, 21);
            this.lable.TabIndex = 5;
            this.lable.Text = "暱稱：";
            // 
            // sfgDialog
            // 
            this.sfgDialog.Filter = "所有文件|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有文件|*.*";
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userName_textBox.Location = new System.Drawing.Point(81, 14);
            this.userName_textBox.MaxLength = 10;
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(100, 23);
            this.userName_textBox.TabIndex = 11;
            this.userName_textBox.Text = "請輸入暱稱";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "檔案路径：";
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
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtReceived.Location = new System.Drawing.Point(15, 22);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(730, 229);
            this.txtReceived.TabIndex = 41;
            this.txtReceived.Text = "";
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
            this.groupBox3.Location = new System.Drawing.Point(6, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 426);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訊息框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 490);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Client";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.SaveFileDialog sfgDialog;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.RichTextBox txtReceived;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

