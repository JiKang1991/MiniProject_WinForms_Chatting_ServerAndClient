using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsChattingClientAndServer.Class;

namespace WinFormsChattingClientAndServer.UserControls
{
    public partial class UCJoin : UserControl
    {
        Control callControl = null;

        public UCJoin(Control callControl)
        {
            InitializeComponent();

            this.callControl = callControl;
        }

        // 라디오버튼 선택 변경 메서드 (RBServer)
        private void RBServer_Click(object sender, EventArgs e)
        {
            // RBServer에 체크되고 RBClient의 체크가 해제됩니다.
            RBServer.Checked = true;
            RBClient.Checked = false;
        }

        // 라디오버튼 선택 변경 메서드 (RBClient)
        private void RBClient_Click(object sender, EventArgs e)
        {
            // RBClient에 체크되고 RBServer의 체크가 해제됩니다.
            RBClient.Checked = true;
            RBServer.Checked = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // GroupBoxJoin을 보이지 않도록 하고 GbInputIpPort를 보이게 합니다.
            GroupBoxJoin.Visible = false;
            GbInputIpPort.VisibleChanged += new EventHandler(GbInputIpPort_VisibleChanged);
            GbInputIpPort.Visible = true;


        }

        private void GbInputIpPort_VisibleChanged(object sender, EventArgs e)
        {
            if (RBServer.Checked == true)
            {
                TbIP1.Text = "000";
                TbIP2.Text = "000";
                TbIP3.Text = "000";
                TbIP4.Text = "000";
                TbPort.Text = "9001";
            }
            else if (RBClient.Checked == true)
            {
                TbIP1.Text = "127";
                TbIP2.Text = "000";
                TbIP3.Text = "000";
                TbIP4.Text = "001";
                TbPort.Text = "9001";
            }
            else
            {
                MessageBox.Show("접속 방법을 선택하세요");
            }
            GbInputIpPort.VisibleChanged -= new EventHandler(GbInputIpPort_VisibleChanged);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // 입력된 데이터가 숫자인지 확인하기위해 각 자리를 이어붙이고 long.Parse() 가능 여부를 확인한다.
            string ip = TbIP1.Text.Trim() + TbIP2.Text.Trim() + TbIP3.Text.Trim() + TbIP4.Text.Trim();
            string port = TbPort.Text.Trim();

            if (IpPortCheck("IP", ip) && IpPortCheck("PORT", port))
            {
                string[] totalIp = { TbIP1.Text.Trim(), TbIP2.Text.Trim(), TbIP3.Text.Trim(), TbIP4.Text.Trim() };
                this.Visible = false;
                if (RBServer.Checked == true)
                {
                    CServerManager cServerManager = new CServerManager(totalIp, port, callControl);
                }
                else if (RBClient.Checked == true)
                {
                    CClientManager cClientManager = new CClientManager(totalIp, port, callControl);
                }
            }

        }

        private bool IpPortCheck(string type, string source)
        {
            try
            {
                long.Parse(source);
                return true;
            }
            catch
            {
                MessageBox.Show($"{type}를 잘못 입력하셨습니다.");
                return false;
            }
        }

    }
}
