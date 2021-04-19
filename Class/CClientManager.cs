using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinFormsChattingClientAndServer.Class;
using WinFormsChattingClientAndServer.UserControls;

namespace WinFormsChattingClientAndServer.Class
{
    class CClientManager
    {
        private string totalIp;
        private int port;
        private Control callControl;
        UCChattingPage uCChattingPage = null;
        Socket socket = null;

        public CClientManager(string[] totalIp, string port, Control callControl)
        {
            this.totalIp = $"{totalIp[0]}.{totalIp[1]}.{totalIp[2]}.{totalIp[3]}";
            this.port = int.Parse(port);
            this.callControl = callControl;

            ConstructionInitialize();
        }

        private void ConstructionInitialize()
        {
            try
            {
                uCChattingPage = new UCChattingPage(null, this);
                uCChattingPage.Dock = DockStyle.Fill;
                callControl.Controls.Add(uCChattingPage);

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(totalIp, port);

                CallCreateInfoControl("서버에 접속하였습니다.");

                CreateReceivedThread();
            }
            catch
            {
                CallCreateInfoControl("서버 접속에 이상이 있습니다.");
            }
        }

        private void CreateReceivedThread()
        {
            CCReceiptProcess cCReceiptProcess = new CCReceiptProcess(socket, this);
            Thread receiptThread = new Thread(cCReceiptProcess.Run);
            receiptThread.IsBackground = true;
            receiptThread.Start();
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
            socket.Send(Encoding.Default.GetBytes(message));
        }
    }
}
