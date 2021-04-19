using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsChattingClientAndServer.Class
{
    class CServerProcess
    {
        Socket serverSocket = null;
        Socket socket = null;
        IAsyncResult ar;
        bool pending = false;
        CSReceiptProcess cSReceivedProcess = null;
        Class.CServerManager csm = null;


        public CServerProcess(Socket serverSocket, Class.CServerManager csm)
        {
            this.serverSocket = serverSocket;
            this.csm = csm;
        }

        private Socket acceptSocket()
        {
            Socket tempSock = serverSocket.EndAccept(ar);
            serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);
            pending = false;
            return tempSock;

        }

        private void OnAccept(IAsyncResult iar)
        {
            pending = true;
            ar = iar;
        }

        public void Run()
        {
            try
            {
                // serverSocket.Bind(iPEndPoint);
                // serverSocket.Listen(100);
                csm.CallCreateInfoControl("서버가 활성화 되었습니다.");

                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);
                while (true)
                {
                    if (pending)
                    {
                        socket = acceptSocket();
                        cSReceivedProcess = new CSReceiptProcess(socket, csm);
                        csm.list.Add(cSReceivedProcess);
                        Thread receivedThread = new Thread(cSReceivedProcess.Run);
                        receivedThread.IsBackground = true;
                        receivedThread.Start();
                    }
                    Thread.Sleep(100);
                }
            }
            finally
            {
                if (serverSocket != null)
                {
                    serverSocket.Close();
                }
            }
        }

    }
}
