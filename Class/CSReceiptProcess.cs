using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinFormsChattingClientAndServer.Enum;

namespace WinFormsChattingClientAndServer.Class
{
    class CSReceiptProcess
    {
        CServerManager csm = null;
        public Socket socket = null;

        public CSReceiptProcess(Socket socket, CServerManager csm)
        {
            this.socket = socket;
            this.csm = csm;
        }

        private string CheckUserInfo()
        {
            string userInfo = ((IPEndPoint)socket.RemoteEndPoint).Port.ToString();
            return userInfo;
        }

        public void Run()
        {
            try
            {
                string userInfo = CheckUserInfo();
                csm.CallCreateInfoControl(userInfo + "님이 접속하였습니다.");
                csm.Broadcast(MessageType.Infomation, userInfo, $"{userInfo}님이 접속하였습니다.");

                while (true)
                {
                    if (socket != null && socket.Available > 0)
                    {
                        byte[] bReceivedMessage = new byte[socket.Available];
                        socket.Receive(bReceivedMessage);
                        string sReceivedMessage = Encoding.Default.GetString(bReceivedMessage);
                        csm.CallCreateMessageControl(sReceivedMessage, userInfo);
                        csm.Broadcast(MessageType.Talk, userInfo, sReceivedMessage);
                    }
                    Thread.Sleep(100);
                }
            }
            finally
            {
                if (socket != null)
                {
                    socket.Close();
                }
            }
        }


    }
}
