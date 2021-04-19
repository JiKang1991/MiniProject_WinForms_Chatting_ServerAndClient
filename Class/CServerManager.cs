using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsChattingClientAndServer.Enum;
using WinFormsChattingClientAndServer.UserControls;

namespace WinFormsChattingClientAndServer.Class
{
    class CServerManager
    {
        Control callControl = null;
        string[] totalIp = null;
        string port = null;
        Socket serverSocket = null;
        public List<CSReceiptProcess> list = new List<CSReceiptProcess>();
        public List<Thread> threadList = new List<Thread>();
        UCChattingPage uCChattingPage = null;

        public CServerManager(string[] totalIp, string port, Control callControl)
        {
            this.totalIp = totalIp;
            this.port = port;
            this.callControl = callControl;

            ConstructionInitialize();
        }

        private void ConstructionInitialize()
        {
            uCChattingPage = new UCChattingPage(this, null);
            uCChattingPage.Dock = DockStyle.Fill;
            callControl.Controls.Add(uCChattingPage);

            CreateServerThread();
        }

        private byte[] GetIpBytes()
        {
            byte[] ba = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                ba[i] = byte.Parse(totalIp[i]);
            }
            return ba;
        }

        private void CreateServerThread()
        {
            IPAddress iPAddress = new IPAddress(GetIpBytes());
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, int.Parse(port));
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(iPEndPoint);
            serverSocket.Listen(100);
            CServerProcess cServerProcess = new CServerProcess(serverSocket, this);
            Thread serverThread = new Thread(new ThreadStart(cServerProcess.Run));
            serverThread.IsBackground = true;
            serverThread.Start();

            CSSessionProcess cSSessionProcess = new CSSessionProcess(this);
            Thread sessionThread = new Thread(new ThreadStart(cSSessionProcess.Run));
            sessionThread.IsBackground = true;
            sessionThread.Start();
        }

        public void Broadcast(MessageType type, string userInfo, string message)
        {
            string str = $"{type}&{userInfo}%{message}";

            for (int i = 0; i < list.Count; i++)
            {
                list[i].socket.Send(Encoding.Default.GetBytes(str));                
            }
        }

        public void CallCreateInfoControl(string message)
        {
            uCChattingPage.CreateInfoControl(message);
        }

        public void CallCreateMessageControl(string message, string userInfo)
        {
            uCChattingPage.CreateUserInfoControl(userInfo);
            uCChattingPage.CreateMessageControl(message);
        }

        public void CallCreateMyMessageControl(string message)
        {
            uCChattingPage.CreateMyMessageControl(message);
        }

        public void SendMessage(String message)
        {
            CallCreateInfoControl(message);
            Broadcast(MessageType.Infomation, "**Server**", message);
        }
    }
}
