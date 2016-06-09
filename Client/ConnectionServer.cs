using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Client
{
    public class ConnectionServer
    {
        private string serverIp = "";
        private string serverPort = "";

        public ConnectionServer(string ip, string port)
        {
            serverIp = ip;
            serverPort = port;
        }

        public Socket Connection2Server()
        {
            try
            {
                Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //用Tcp方式連線
                IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse(serverIp), int.Parse(serverPort));
                socketClient.Connect(ipendpoint);

                return socketClient;
            }
            catch (Exception ex)
            {
                throw new Exception("伺服器連線失敗..." + ex.Message);

            }
        }
    }
}
