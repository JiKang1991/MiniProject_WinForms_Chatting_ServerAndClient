using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinFormsChattingClientAndServer.Enum;
using WinFormsChattingClientAndServer.UserControls;

namespace WinFormsChattingClientAndServer.Class
{
    class CCReceiptProcess
    {
        Socket socket = null;
        CClientManager ccm = null;

        public CCReceiptProcess(Socket socket, CClientManager ccm)
        {
            this.socket = socket;
            this.ccm = ccm;
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    if (socket != null && socket.Available > 0)
                    {
                        byte[] bReceivedMessage = new byte[socket.Available];
                        socket.Receive(bReceivedMessage);

                        string[] decodedMessages = DecodeMessage(bReceivedMessage);

                        string type = decodedMessages[0];
                        string userInfo = decodedMessages[1];
                        string message = decodedMessages[2];

                        string myPort = ((IPEndPoint)socket.LocalEndPoint).Port.ToString();

                        if (type.Equals("Talk"))
                        {
                            if (myPort.Equals(userInfo))
                            {
                                ccm.CallCreateMyMessageControl(message);
                            }
                            else
                            {
                                ccm.CallCreateMessageControl(message, userInfo);
                            }
                        }
                        else
                        {
                            ccm.CallCreateInfoControl(message);
                        }



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

        private string[] DecodeMessage(byte[] receivedMessage)
        {
            string sReceivedMessage = Encoding.Default.GetString(receivedMessage);
            int lengthOfType = sReceivedMessage.IndexOf('&');
            int startIndexOfUserInfo = sReceivedMessage.IndexOf('&') + 1;
            int lengthOfUserInfo = sReceivedMessage.IndexOf('%') - startIndexOfUserInfo;
            int startIndexOfMessage = sReceivedMessage.IndexOf('%') + 1;
            int lengthOfMessage = sReceivedMessage.Length - startIndexOfMessage;

            string type = sReceivedMessage.Substring(0, lengthOfType);
            string userInfo = sReceivedMessage.Substring(startIndexOfUserInfo, lengthOfUserInfo);
            string message = sReceivedMessage.Substring(startIndexOfMessage, lengthOfMessage);

            string[] decodedMessages = { type, userInfo, message };
            return decodedMessages;
        }


    }
}
