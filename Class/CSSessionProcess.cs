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
    class CSSessionProcess
    {
        CServerManager csm = null;        

        public CSSessionProcess(CServerManager csm)
        {
            this.csm = csm;            
        }

        private bool IsAlive(Socket socket)
        {
            if (socket == null) return false;
            if (!socket.Connected) return false;

            bool r1 = socket.Poll(1000, SelectMode.SelectRead);
            bool r4 = socket.Available == 0;
            if (r1 && r4) return false;
            else
            {
                try
                {
                    socket.Send(new byte[1], 0, SocketFlags.OutOfBand);   // 원래 프로토콜에 의한 Connection 점검시 사용하는 방법
                    return true;
                }
                catch   // 오류가 발생하면 소켓 이상으로 판단
                {
                    return false;
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                for (int i = 0; i < csm.list.Count; i++)
                {
                    if (IsAlive(csm.list[i].socket))
                    {

                    }
                    else
                    {
                        string userInfo = ((IPEndPoint)csm.list[i].socket.RemoteEndPoint).Port.ToString();
                        csm.list[i].socket.Close();
                        csm.list.RemoveAt(i);
                        csm.threadList[i].Abort();
                        csm.threadList.RemoveAt(i);
                        csm.SendMessage(userInfo + "님이 접속을 종료하였습니다.");
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
