
namespace WinFormsChattingClientAndServer.UserControls
{
    partial class UCJoin
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxJoin = new System.Windows.Forms.GroupBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.RBClient = new System.Windows.Forms.RadioButton();
            this.RBServer = new System.Windows.Forms.RadioButton();
            this.GbInputIpPort = new System.Windows.Forms.GroupBox();
            this.LbPort = new System.Windows.Forms.Label();
            this.LbIp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIP4 = new System.Windows.Forms.TextBox();
            this.TbIP3 = new System.Windows.Forms.TextBox();
            this.TbIP2 = new System.Windows.Forms.TextBox();
            this.TbIP1 = new System.Windows.Forms.TextBox();
            this.TbPort = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.GroupBoxJoin.SuspendLayout();
            this.GbInputIpPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxJoin
            // 
            this.GroupBoxJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxJoin.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxJoin.Controls.Add(this.BtnNext);
            this.GroupBoxJoin.Controls.Add(this.RBClient);
            this.GroupBoxJoin.Controls.Add(this.RBServer);
            this.GroupBoxJoin.Location = new System.Drawing.Point(6, 31);
            this.GroupBoxJoin.Name = "GroupBoxJoin";
            this.GroupBoxJoin.Size = new System.Drawing.Size(289, 438);
            this.GroupBoxJoin.TabIndex = 1;
            this.GroupBoxJoin.TabStop = false;
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNext.Location = new System.Drawing.Point(100, 242);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // RBClient
            // 
            this.RBClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBClient.AutoSize = true;
            this.RBClient.Location = new System.Drawing.Point(88, 193);
            this.RBClient.Name = "RBClient";
            this.RBClient.Size = new System.Drawing.Size(107, 16);
            this.RBClient.TabIndex = 0;
            this.RBClient.TabStop = true;
            this.RBClient.Text = "Enter By Client";
            this.RBClient.UseVisualStyleBackColor = true;
            this.RBClient.Click += new System.EventHandler(this.RBClient_Click);
            // 
            // RBServer
            // 
            this.RBServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBServer.AutoSize = true;
            this.RBServer.Location = new System.Drawing.Point(88, 146);
            this.RBServer.Name = "RBServer";
            this.RBServer.Size = new System.Drawing.Size(111, 16);
            this.RBServer.TabIndex = 0;
            this.RBServer.TabStop = true;
            this.RBServer.Text = "Enter By Server";
            this.RBServer.UseVisualStyleBackColor = true;
            this.RBServer.Click += new System.EventHandler(this.RBServer_Click);
            // 
            // GbInputIpPort
            // 
            this.GbInputIpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbInputIpPort.BackColor = System.Drawing.SystemColors.Control;
            this.GbInputIpPort.Controls.Add(this.LbPort);
            this.GbInputIpPort.Controls.Add(this.LbIp);
            this.GbInputIpPort.Controls.Add(this.label2);
            this.GbInputIpPort.Controls.Add(this.label3);
            this.GbInputIpPort.Controls.Add(this.label1);
            this.GbInputIpPort.Controls.Add(this.TbIP4);
            this.GbInputIpPort.Controls.Add(this.TbIP3);
            this.GbInputIpPort.Controls.Add(this.TbIP2);
            this.GbInputIpPort.Controls.Add(this.TbIP1);
            this.GbInputIpPort.Controls.Add(this.TbPort);
            this.GbInputIpPort.Controls.Add(this.BtnEnter);
            this.GbInputIpPort.Location = new System.Drawing.Point(6, 31);
            this.GbInputIpPort.Name = "GbInputIpPort";
            this.GbInputIpPort.Size = new System.Drawing.Size(289, 438);
            this.GbInputIpPort.TabIndex = 2;
            this.GbInputIpPort.TabStop = false;
            this.GbInputIpPort.Visible = false;
            // 
            // LbPort
            // 
            this.LbPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbPort.AutoSize = true;
            this.LbPort.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbPort.Location = new System.Drawing.Point(108, 210);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(67, 12);
            this.LbPort.TabIndex = 3;
            this.LbPort.Text = "Server Port";
            this.LbPort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LbIp
            // 
            this.LbIp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbIp.AutoSize = true;
            this.LbIp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbIp.Location = new System.Drawing.Point(114, 117);
            this.LbIp.Name = "LbIp";
            this.LbIp.Size = new System.Drawing.Size(55, 12);
            this.LbIp.TabIndex = 3;
            this.LbIp.Text = "Server Ip";
            this.LbIp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(137, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(188, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(85, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TbIP4
            // 
            this.TbIP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbIP4.Location = new System.Drawing.Point(207, 161);
            this.TbIP4.Name = "TbIP4";
            this.TbIP4.Size = new System.Drawing.Size(30, 21);
            this.TbIP4.TabIndex = 2;
            this.TbIP4.Text = "000";
            this.TbIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIP3
            // 
            this.TbIP3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbIP3.Location = new System.Drawing.Point(155, 161);
            this.TbIP3.Name = "TbIP3";
            this.TbIP3.Size = new System.Drawing.Size(30, 21);
            this.TbIP3.TabIndex = 2;
            this.TbIP3.Text = "000";
            this.TbIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIP2
            // 
            this.TbIP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbIP2.Location = new System.Drawing.Point(104, 161);
            this.TbIP2.Name = "TbIP2";
            this.TbIP2.Size = new System.Drawing.Size(30, 21);
            this.TbIP2.TabIndex = 2;
            this.TbIP2.Text = "000";
            this.TbIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIP1
            // 
            this.TbIP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbIP1.Location = new System.Drawing.Point(52, 161);
            this.TbIP1.Name = "TbIP1";
            this.TbIP1.Size = new System.Drawing.Size(30, 21);
            this.TbIP1.TabIndex = 2;
            this.TbIP1.Text = "000";
            this.TbIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbPort
            // 
            this.TbPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPort.Location = new System.Drawing.Point(89, 242);
            this.TbPort.Name = "TbPort";
            this.TbPort.Size = new System.Drawing.Size(100, 21);
            this.TbPort.TabIndex = 2;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEnter.Location = new System.Drawing.Point(100, 287);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // UCJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbInputIpPort);
            this.Controls.Add(this.GroupBoxJoin);
            this.Name = "UCJoin";
            this.Size = new System.Drawing.Size(300, 500);
            this.GroupBoxJoin.ResumeLayout(false);
            this.GroupBoxJoin.PerformLayout();
            this.GbInputIpPort.ResumeLayout(false);
            this.GbInputIpPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxJoin;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.RadioButton RBClient;
        private System.Windows.Forms.RadioButton RBServer;
        private System.Windows.Forms.GroupBox GbInputIpPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIP4;
        private System.Windows.Forms.TextBox TbIP3;
        private System.Windows.Forms.TextBox TbIP2;
        private System.Windows.Forms.TextBox TbIP1;
        private System.Windows.Forms.TextBox TbPort;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LbPort;
        private System.Windows.Forms.Label LbIp;
    }
}
