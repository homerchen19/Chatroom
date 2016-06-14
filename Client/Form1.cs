using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Collections;
using System.IO;
using Common;
using System.Diagnostics;

namespace Client {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;

            this.groupBox3.Enabled = false;
        }

        Socket socketClient = null;
        string localName, userName;
        bool receiveFlag = true;

        //連線
        private void btnConnection_Click ( object sender, EventArgs e ) {
            if(userName_textBox.Text == "")
            {
                MessageBox.Show("需要輸入暱稱才能連線");
            }
            else
            {
                userName = userName_textBox.Text;
                ConnectionServer connectionserver = new ConnectionServer("13.75.120.16", "5555"); //server IP and port
                //ConnectionServer connectionserver = new ConnectionServer("127.0.0.1", "5555"); //server IP and port

                socketClient = connectionserver.Connection2Server(); //連線至server
                localName = socketClient.LocalEndPoint.ToString();
                this.btnConnection.Enabled = false;
                Thread thrReceived = new Thread(ReceiveMsg); //建立線程來監聽訊息
                thrReceived.IsBackground = true;
                thrReceived.SetApartmentState(ApartmentState.STA);
                thrReceived.Start();

                receiveFlag = true; //開始監聽
                this.groupBox3.Enabled = true;
                this.txtReceived.Text = "";
                this.txtReceived.AppendTxt("等待配對中...");
                this.txtMessage.Enabled = false;
                this.userName_textBox.Enabled = false;
                this.btnShake.Enabled = false;
                this.btnSendMsg.Enabled = false;
                this.btnSendFile.Enabled = false;
            }
        }

        // 永久監聽線程
        
        private void ReceiveMsg () {
            try {
                while (receiveFlag) {
                    
                    byte [] bytes = new byte [1024 * 1024 * 2];
                    socketClient.Receive(bytes);
                    string receiveMsg = Encoding.UTF8.GetString(bytes);
                    Debug.Print(receiveMsg);
                    MessageMod mod = new MessageMod(receiveMsg);
                    switch (mod.MsgType) {
                        //一般傳訊息
                        case (int)Common.PubClass.MsgType.Client2Client:
                            this.txtReceived.AppendTxt(string.Format("{0}：{1}", mod.FromUser_Name, mod.Content));
                            break;
                        // 踢人
                        case (int)Common.PubClass.MsgType.TR:
                            this.txtReceived.AppendTxt(mod.Content);
                            socketClient.Close();
                            receiveFlag = false;
                            System.Timers.Timer tim = new System.Timers.Timer(3000);
                            tim.Enabled = true;
                            tim.Elapsed += ( object sender, System.Timers.ElapsedEventArgs e ) => { this.Close(); };
                            break;
                        //伺服器關閉
                        case (int)Common.PubClass.MsgType.ServerClosed:
                            socketClient.Close();
                            this.txtReceived.AppendTxt("伺服器連線失敗，3秒後即將關閉視窗...");
                            System.Timers.Timer timer = new System.Timers.Timer(3000);
                            timer.Enabled = true;
                            timer.Elapsed += ( object sender, System.Timers.ElapsedEventArgs e ) => { this.Close(); };
                            break;
                        //禁言
                        case (int)Common.PubClass.MsgType.JY:
                            this.txtReceived.AppendTxt(mod.Content);
                            this.btnSendMsg.Enabled = false;
                            this.txtMessage.Enabled = false;
                            this.txtMessage.BackColor = Color.Red;
                            break;
                        // 解禁言
                        case (int)Common.PubClass.MsgType.CancelJY:
                            this.txtReceived.AppendTxt(mod.Content);
                            this.btnSendMsg.Enabled = true;
                            this.txtMessage.Enabled = true;
                            this.txtMessage.BackColor = Color.White;
                            break;
                        //接收檔案
                        case (int)Common.PubClass.MsgType.Client2ClientFile:
                            if (MessageBox.Show("是否接收？", mod.FromUser + "傳送的檔案", MessageBoxButtons.YesNoCancel)
            == System.Windows.Forms.DialogResult.Yes) {
                                if (sfgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                    using (FileStream fs = new FileStream(sfgDialog.FileName, FileMode.Create)) {
                                        fs.Write(mod.ContentBytes, 0, mod.ContentBytes.Length);
                                        txtReceived.AppendTxt("接收了一個檔案" + sfgDialog.FileName);
                                    }
                                } else {
                                    txtReceived.AppendTxt("取消接收文件" + sfgDialog.FileName);
                                }
                            }
                            break;
                        //叮咚
                        case (int)Common.PubClass.MsgType.ShineScreen:
                            this.txtReceived.SelectionFont = new Font("微軟正黑體", 14, FontStyle.Bold); 
                            this.txtReceived.SelectionColor = Color.Red;
                            this.txtReceived.AppendTxt("叮咚！有人在家嗎～～");
                            this.txtReceived.SelectionFont = new Font("微軟正黑體", 12, FontStyle.Regular);
                            this.txtReceived.SelectionColor = Color.Black;
                            ShakeWindow();
                            break;
                        //管理員 to 用戶
                        case (int)Common.PubClass.MsgType.Server2ClientMsg:
                            this.txtReceived.AppendTxt(string.Format("管理員：{0}", mod.Content));
                            break;
                        //配對
                        case (int)Common.PubClass.MsgType.Check:
                            this.txtReceived.AppendTxt(mod.Content);
                            this.txtMessage.Enabled = true;
                            this.btnShake.Enabled = true;
                            this.btnSendMsg.Enabled = true;
                            this.btnSendFile.Enabled = true;
                            break;
                        //對方離線
                        case (int)Common.PubClass.MsgType.Offline:
                            this.txtReceived.SelectionFont = new Font("微軟正黑體", 12, FontStyle.Bold);
                            this.txtReceived.AppendTxt(mod.Content);
                            this.txtReceived.SelectionFont = new Font("微軟正黑體", 12, FontStyle.Regular);
                            this.txtMessage.Enabled = false;
                            this.btnShake.Enabled = false;
                            this.btnSendMsg.Enabled = false;
                            this.btnSendFile.Enabled = false;

                            this.userName_textBox.Enabled = true;
                            this.btnConnection.Enabled = true;
                            socketClient.Close();
                            receiveFlag = false;

                            break;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("伺服器連線失敗，3秒後即將關閉視窗..." + ex.Message);
                receiveFlag = false;
                System.Timers.Timer timer = new System.Timers.Timer(3000);
                timer.Enabled = true;
                timer.Elapsed += ( object sender, System.Timers.ElapsedEventArgs e ) => { this.Close(); };
            }
        }

        // 傳送訊息
        private void btnSendMsg_Click ( object sender, EventArgs e ) {
            if (txtMessage.Text.Length == 0) return;

            if (receiveFlag) {
                MessageMod mod = new MessageMod();
                mod.MsgType = (int)Common.PubClass.MsgType.Client2Client;
                mod.FromUser = localName;
                mod.FromUser_Name = userName;
                mod.ToUser = "";
                mod.Content = this.txtMessage.Text;
                socketClient.Send(mod.ToBytes());
                txtReceived.AppendTxt(string.Format("{0}：{1}", mod.FromUser_Name, mod.Content));
                this.txtMessage.Clear();
                this.txtMessage.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
            else {
                MessageBox.Show("伺服器停止回應");
            }
        }

        //傳送檔案
        private void btnSendFile_Click ( object sender, EventArgs e ) {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = openFileDialog.FileName;
                this.txtFilePath.Enabled = false;
            }

            string fileName = txtFilePath.Text;
            if (string.IsNullOrEmpty(fileName)) {
                MessageBox.Show("請選擇檔案");
                return;
            }

            //將檔案打包成mod
            MessageMod mod = new MessageMod();
            using (FileStream fs = new FileStream(fileName, FileMode.Open)) {
                byte[] byts = new byte[fs.Length];
                fs.Read(byts, 0, (int)byts.Length);
                mod.ContentBytes = byts;
                //mod.ContentBytes = File.ReadAllBytes(fileName);
                fs.Close();
            }
            mod.MsgType = (int)Common.PubClass.MsgType.Client2ClientFile;
            mod.FromUser = localName;
            mod.FromUser_Name = userName;
            mod.ToUser = "";
            mod.Content = fileName;
            socketClient.Send(mod.ToBytes(), 0, mod.ToBytes().Length, SocketFlags.None); //傳送出去
            txtFilePath.Text = "";
        }

        //叮咚
        private void btnShake_Click ( object sender, EventArgs e ) {
            MessageMod mod = new MessageMod();
            mod.MsgType = (int)Common.PubClass.MsgType.ShineScreen;
            mod.FromUser = localName;
            mod.FromUser_Name = userName;
            mod.ToUser = "";
            mod.Content = "叮咚！有人在家嗎～～";
            socketClient.Send(mod.ToBytes());

            this.txtReceived.SelectionFont = new Font("微軟正黑體", 14, FontStyle.Bold);
            this.txtReceived.SelectionColor = Color.Red;
            this.txtReceived.AppendTxt("叮咚！有人在家嗎～～");
            this.txtReceived.SelectionFont = new Font("微軟正黑體", 12, FontStyle.Regular);
            this.txtReceived.SelectionColor = Color.Black;
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if ( !e.Shift && e.KeyCode == Keys.Enter) //catch enter keypress
            {
                if (string.IsNullOrEmpty(txtFilePath.Text))
                    btnSendMsg.PerformClick();
                else
                    btnSendFile.PerformClick();
            }
        }

        //晃動螢幕
        public void ShakeWindow () {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            Random ran = new Random();
            System.Drawing.Point point = this.Location;
            for (int i = 0 ; i < 10 ; i++) {
                this.Location = new System.Drawing.Point(point.X + ran.Next(6), point.Y + ran.Next(6));
                System.Threading.Thread.Sleep(10);
                this.Location = point;
                System.Threading.Thread.Sleep(10);
            }
        }
        
    }
}
