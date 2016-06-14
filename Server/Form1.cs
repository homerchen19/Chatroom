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
using System.IO;
using Common;
using System.Diagnostics;

namespace Server
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            ComboBox.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        //伺服器socket
        Socket socketServer = null;

        //監聽線程
        Thread thrReadRec = null;

        //client端列表
        Dictionary<string, Socket> dictClients = new Dictionary<string, Socket>();

        // 最多連線數量
        int maxCount = 0;
        private void btnBeginListen_Click(object sender, EventArgs e)
        {
            this.txtStatu.Text = "執行中...";
            maxCount = int.Parse(cboMaxCount.SelectedItem.ToString());
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddress = IPAddress.Parse(txtSerIP.Text.ToString());
            IPEndPoint ipendpoint = new IPEndPoint(ipaddress, int.Parse(txtSerPort.Text.ToString())); //用ip和port來初始化 IPEndPoint 類別的新執行個體
            socketServer.Bind(ipendpoint);  //socket連線到該ip
            socketServer.Listen(maxCount); // 啟動監聽

            //開一個線程負責監聽
            Thread threadWatch = new Thread(WatchConnection);
            threadWatch.IsBackground = true; // 設定線程在後台執行
            threadWatch.Start();

            this.txtLog.AppendTxt("伺服器執行中...");
            this.btnBeginListen.Enabled = false;
            this.btnPause.Enabled = true;
            this.txtStatu.Enabled = false;
            this.txtSerName.Enabled = false;
            this.txtSerIP.Enabled = false;
            this.txtSerPort.Enabled = false;
            this.txtNowCount.Enabled = false;
            this.cboMaxCount.Enabled = false;
        }

        //配對
        Dictionary<string, string> user_dic = new Dictionary<string, string>();
        int user_count = 0;
        string ClientName_2, userPort;

        // 永久監聽連線線程
        bool watchFlag = true;
        private void WatchConnection()
        {
            try
            {
                while (watchFlag)
                {
                    Socket socketConn = socketServer.Accept(); //建立新連接的socket
                    string clientName = socketConn.RemoteEndPoint.ToString(); //用戶名稱(IP:port)
                    string clientNamePort = ((IPEndPoint)socketConn.RemoteEndPoint).Port.ToString(); //用戶Port
                    this.lstClient.Items.Add(clientName); //加到用戶列表
                    dictClients.Add(clientName, socketConn); //儲存一個用戶，一個socket
                    if (dictClients.Count > maxCount)
                    {
                        txtLog.AppendTxt(clientName + "連線失敗, 原因：【目前連線數量已超過最大限制】");
                        Server2ClientMsg(clientName, "目前連線數量已超過最大限制，請稍後重試...", false);
                        socketConn.Close();
                    }

                    user_count += 1;
                    if (user_count == 2) //偶數
                    {
                        user_dic.Add(userPort, clientName); //port -> IP
                        user_dic.Add(clientNamePort, ClientName_2); //port -> IP
                        user_count = 0;
                        Server2ClientMsg(ClientName_2, "配對成功", false, Common.PubClass.MsgType.Check);
                        Server2ClientMsg(clientName, "配對成功", false, Common.PubClass.MsgType.Check);
                    }
                    else if (user_count == 1)
                    {
                        ClientName_2 = clientName;
                        userPort = clientNamePort;
                    }

                    this.txtLog.AppendTxt("用戶連線成功：" + clientName);
                    this.txtNowCount.Text = (int.Parse(txtNowCount.Text.ToString()) + 1).ToString();
                    thrReadRec = new Thread(() => { ReceiveMsg(socketConn); }); //開啟新的線程監聽訊息
                    thrReadRec.IsBackground = true;
                    thrReadRec.Start();
                }
            }
            catch (Exception)
            {

            }
        }

        // 監聽接收訊息的線程
        private void ReceiveMsg(Socket socketConn)
        {
            try
            {
                while (true)
                {
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    socketConn.Receive(bytes); //從已連接的Socket接收資料至接收緩衝區中
                    string receiveMsg = Encoding.UTF8.GetString(bytes);
                    MessageMod mod = new MessageMod(receiveMsg);
                    string FromUserPort = mod.FromUser.Split(':')[1];
                    mod.ToUser = user_dic[FromUserPort];

                    switch (mod.MsgType)
                    {
                        case (int)Common.PubClass.MsgType.Client2Client:
                            this.txtServerState.AppendTxt(string.Format("【{0}】 對 【{1}】 說：{2}", mod.FromUser, mod.ToUser, mod.Content));

                            foreach (var item in dictClients)
                            {
                                if (item.Key == mod.ToUser)
                                {
                                    item.Value.Send(bytes);
                                }
                            }
                            break;
                        case (int)Common.PubClass.MsgType.Client2ClientFile:
                            txtServerState.AppendTxt(string.Format("【{0}】 對 【{1}】 傳送了一個檔案：【{2}】", mod.FromUser, mod.ToUser, mod.Content));
                            SendFile(mod, false);
                            txtServerState.AppendTxt("傳送完成, 檔案大小：" + mod.ContentBytes.Length.ToString() + "kb");
                            break;
                        case (int)Common.PubClass.MsgType.ShineScreen: //叮咚
                            txtServerState.AppendTxt(string.Format("【{0}】 對 【{1}】傳送了一個叮咚", mod.FromUser, mod.ToUser));
                            Server2ClientMsg(mod.ToUser, mod.Content, false, PubClass.MsgType.ShineScreen);
                            break;
                    }
                }
            }
            catch
            {
                string connName = socketConn.RemoteEndPoint.ToString();
                string connNamePort = ((IPEndPoint)socketConn.RemoteEndPoint).Port.ToString();
                this.txtLog.AppendTxt(connName + " 已離線");

                if (user_dic.ContainsKey(connNamePort))
                {
                    Server2ClientMsg(user_dic[connNamePort], "對方已離線", false, Common.PubClass.MsgType.Offline);
                    user_dic.Remove(user_dic[connNamePort].Split(':')[1]); //從user_dic中移除
                    user_dic.Remove(connNamePort);
                }

                txtNowCount.Text = (int.Parse(txtNowCount.Text) - 1).ToString();
                dictClients.Remove(connName); //從dictClients中移除socket
                this.lstClient.Items.Remove(connName);
            }
        }

        #region 傳送消息給單一用戶
        private void btnSend_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, this.txtSend.Text, false);
        }

        // 選擇用戶
        private string GetSelectClient()
        {
            if (lstClient.SelectedItem != null)
            {
                return lstClient.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一個用戶"); return "";
            }
        }
        #endregion

        #region 傳送訊息給全體用戶
        private void btnSendAll_Click(object sender, EventArgs e)
        {
            string msg = this.txtSend.Text;
            Server2AllClientMsg(msg, PubClass.MsgType.Server2ClientMsg);
        }

        private void Server2AllClientMsg(string msg, Common.PubClass.MsgType type)
        {
            Server2ClientMsg("all", msg, true, type);
        }

        private void Server2ClientMsg(string toUser, string msg, bool isAll, Common.PubClass.MsgType type = Common.PubClass.MsgType.Server2ClientMsg)
        {
            //處理訊息，建立每個訊息的詳細資訊
            MessageMod mod = new MessageMod();
            mod.MsgType = (int)type;
            mod.FromUser = socketServer.LocalEndPoint.ToString();
            mod.ToUser = toUser;
            mod.Content = msg;
            mod.ContentBytes = new byte[1];
            byte[] bytes = mod.ToBytes();
            txtServerState.AppendTxt("【" + txtSerName.Text + "】" + " 對 " + "【" + mod.ToUser + "】" + " 說：" + msg);

            foreach (KeyValuePair<string, Socket> item in dictClients)
            {
                if (isAll) //全體
                {
                    item.Value.Send(bytes);
                }
                else if (item.Key == toUser)
                {
                    item.Value.Send(bytes);
                }
            }
        }
        #endregion

        #region 傳送檔案
        private void SendFile(MessageMod mod, bool isAll)
        {
            byte[] byts = mod.ToBytes();
            foreach (KeyValuePair<string, Socket> item in dictClients)
            {
                if (isAll)
                {
                    item.Value.Send(byts);
                }
                else if (item.Key == mod.ToUser)
                {
                    item.Value.Send(byts);
                }
            }
        }
        #endregion

        #region 暫停
        bool pauseFlag = true;
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (pauseFlag)
            {
                socketServer.Blocking = true;
                this.txtStatu.Text = "暫停中...";
                this.btnPause.Text = "繼續";
                pauseFlag = false;
                this.txtLog.AppendTxt("伺服器暫停中...");
            }
            else
            {
                socketServer.Blocking = false;
                this.txtStatu.Text = "執行中...";
                this.btnPause.Text = "暫停";
                pauseFlag = true;
                this.txtLog.AppendTxt("伺服器繼續執行中...");
            }
        }
        #endregion

        #region 踢人
        private void btnTR_Click(object sender, EventArgs e)
        {
            user_count -= 1;
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理員強制下線了", false, PubClass.MsgType.TR);
            dictClients.Remove(currentClient); //從dictionary中移除
            this.lstClient.Items.Remove(currentClient);
            txtLog.AppendTxt(currentClient + "被管理員強制下線了");
            Server2AllClientMsg(currentClient + "被管理員強制下線", PubClass.MsgType.Server2ClientMsg);
        }
        #endregion

        #region 禁言
        private void btnJY_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理員禁言", false, PubClass.MsgType.JY);
        }

        // 解除禁言
        private void btnCancelJY_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理員解除禁言", false, PubClass.MsgType.CancelJY);
        }
        #endregion

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Append))
                {
                    byte[] byts = Encoding.UTF8.GetBytes(txtLog.Text);
                    fs.Write(byts, 0, byts.Length);
                    MessageBox.Show("log保存成功" + saveFileDialog.FileName);
                }
            }
        }

        private void btnShankAll_Click(object sender, EventArgs e)
        {
            Server2AllClientMsg("管理員叮咚全體", PubClass.MsgType.ShineScreen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboMaxCount.SelectedIndex = 0;
        }

    }
}
