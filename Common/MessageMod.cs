using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class MessageMod
    {
        public MessageMod()
        {

        }
        public MessageMod(string str)
        {
            try
            {
                string[] strs = str.Split('|');
                if (strs.Length < 7)
                {
                    this.MsgType = Convert.ToInt32(strs[0]);
                    this.FromUser = Convert.ToString(strs[1]);
                    this.FromUser_Name = Convert.ToString(strs[2]);
                    this.ToUser = Convert.ToString(strs[3]);
                    this.Content = Convert.ToString(strs[4].Trim("\0".ToCharArray()));
                    this.ContentBytes = Encoding.UTF8.GetBytes(strs[5].Trim("\0".ToCharArray()));
                }
                else
                {
                    this.MsgType = 0;
                    this.FromUser = "";
                    this.FromUser_Name = "";
                    this.ToUser = "";
                    this.Content = "";
                    this.ContentBytes = new byte[1];
                }

            }
            catch
            {
                this.MsgType = 0;
                this.FromUser = "";
                this.FromUser_Name = "";
                this.ToUser = "";
                this.Content = "";
                this.ContentBytes = new byte[1];
            }
        }

        //訊息type
        private int _msgType;

        public int MsgType
        {
            get
            {
                return _msgType;
            }
            set { _msgType = value; }
        }

        //傳送者
        public string FromUser { get; set; }

        //傳送者
        public string FromUser_Name { get; set; }

        // 接收者
        public string ToUser { get; set; }

        // 訊息内容
        public string Content { get; set; }


        // 訊息内容 byte[]
        private byte[] _ContentBytes = new byte[1];

        public byte[] ContentBytes
        {
            get
            {
                return _ContentBytes;
            }
            set { _ContentBytes = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}", MsgType, FromUser, FromUser_Name, ToUser, Content, Encoding.UTF8.GetString(ContentBytes));
        }

        public byte[] ToBytes()
        {
            byte[] byts = Encoding.UTF8.GetBytes(this.ToString());
            return byts;
        }
        [Obsolete]
        public byte[] ToBytes(byte[] newBytes)
        {
            byte[] byts = Encoding.UTF8.GetBytes(this.ToString() + "|");
            byte[] bytFinal = new byte[byts.Length + newBytes.Length];
            Buffer.BlockCopy(byts, 0, bytFinal, 0, byts.Length);
            Buffer.BlockCopy(newBytes, 0, bytFinal, byts.Length, newBytes.Length);
            return bytFinal;
        }

    }
}
