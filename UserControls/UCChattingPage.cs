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
    partial class UCChattingPage : UserControl
    {
        int controlLocationY = 0;
        CServerManager csm = null;
        CClientManager ccm = null;

        public UCChattingPage(CServerManager csm, CClientManager ccm)
        {
            InitializeComponent();

            this.csm = csm;
            this.ccm = ccm;
        }

        delegate void PrintMessageCB(Control control);

        private void PrintMessage(Control control)
        {
            if (PanelChattingPage.InvokeRequired)
            {
                Invoke(new PrintMessageCB(PrintMessage), control);
            }
            else
            {                
                PanelChattingPage.Controls.Add(control);
            }
        }

        public void CreateInfoControl(string message)
        {
            Label infoLabel = new Label();
            infoLabel.Text = message;
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoLabel.Size = new Size(PanelChattingPage.Size.Width, 20);
            infoLabel.BackColor = Color.DeepSkyBlue;
            infoLabel.ForeColor = Color.White;
            infoLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            infoLabel.Location = new Point(0, controlLocationY);
            controlLocationY += infoLabel.Size.Height + 5;

            PrintMessage(infoLabel);
        }

        public void CreateUserInfoControl(string user)
        {
            Panel messagePanel = new Panel();
            messagePanel.Location = new Point(0, controlLocationY);
            messagePanel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            messagePanel.Padding = new Padding(10, 0, 0, 0);

            Label userLabel = new Label();
            userLabel.Text = $"{user}'s message :";
            userLabel.MaximumSize = new Size((int)(Width * 0.7), 0);
            userLabel.AutoSize = true;
            userLabel.TextAlign = ContentAlignment.MiddleLeft;
            userLabel.BackColor = Color.IndianRed;
            userLabel.Dock = DockStyle.Left;
            userLabel.Parent = messagePanel;

            messagePanel.Controls.Add(userLabel);
            messagePanel.Size = new Size(PanelChattingPage.Size.Width, userLabel.Height);
            controlLocationY += messagePanel.Size.Height;
            PrintMessage(messagePanel);
        }


        public void CreateMessageControl(string message)
        {
            Panel messagePanel = new Panel();
            messagePanel.Location = new Point(0, controlLocationY);
            messagePanel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            messagePanel.Padding = new Padding(10, 0, 0, 0);

            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.MaximumSize = new Size((int)(Width * 0.7), 0);
            messageLabel.AutoSize = true;
            messageLabel.TextAlign = ContentAlignment.MiddleLeft;
            messageLabel.BackColor = Color.White;
            messageLabel.Dock = DockStyle.Left;
            messageLabel.Parent = messagePanel;

            messagePanel.Controls.Add(messageLabel);

            messagePanel.Size = new Size(PanelChattingPage.Size.Width, messageLabel.Height);
            controlLocationY += messagePanel.Size.Height + 5;

            PrintMessage(messagePanel);

        }

        public void CreateMyMessageControl(string message)
        {
            Panel messagePanel = new Panel();
            messagePanel.Location = new Point(0, controlLocationY);
            messagePanel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            messagePanel.Padding = new Padding(0, 0, 10, 0);

            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.MaximumSize = new Size((int)(Width * 0.7), 0);
            messageLabel.AutoSize = true;
            messageLabel.TextAlign = ContentAlignment.MiddleLeft;
            messageLabel.BackColor = Color.Yellow;
            messageLabel.Dock = DockStyle.Right;
            messageLabel.Parent = messagePanel;

            messagePanel.Controls.Add(messageLabel);

            messagePanel.Size = new Size(PanelChattingPage.Size.Width, messageLabel.Height);
            controlLocationY += messagePanel.Size.Height + 5;

            PrintMessage(messagePanel);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (csm != null)
            {
                csm.SendMessage(TBWrite.Text);
            }
            else if (ccm != null)
            {
                ccm.SendMessage(TBWrite.Text);
            }
            else
            {
                CreateInfoControl("오류로 인해 메시지가 전달되지 않았습니다.");
            }
            TBWrite.Clear();
        }       
    }
}
