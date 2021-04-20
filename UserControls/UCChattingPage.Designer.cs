
namespace WinFormsChattingClientAndServer.UserControls
{
    partial class UCChattingPage
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
            this.PanelWrite = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TBWrite = new System.Windows.Forms.TextBox();
            this.PanelChattingPage = new System.Windows.Forms.Panel();
            this.PanelWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWrite
            // 
            this.PanelWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelWrite.Controls.Add(this.BtnSend);
            this.PanelWrite.Controls.Add(this.TBWrite);
            this.PanelWrite.Location = new System.Drawing.Point(0, 376);
            this.PanelWrite.Name = "PanelWrite";
            this.PanelWrite.Size = new System.Drawing.Size(300, 124);
            this.PanelWrite.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(239, 4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(56, 33);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TBWrite
            // 
            this.TBWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBWrite.Location = new System.Drawing.Point(3, 0);
            this.TBWrite.Multiline = true;
            this.TBWrite.Name = "TBWrite";
            this.TBWrite.Size = new System.Drawing.Size(232, 121);
            this.TBWrite.TabIndex = 0;
            // 
            // PanelChattingPage
            // 
            this.PanelChattingPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChattingPage.AutoScroll = true;
            this.PanelChattingPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelChattingPage.Location = new System.Drawing.Point(4, 4);
            this.PanelChattingPage.Name = "PanelChattingPage";
            this.PanelChattingPage.Size = new System.Drawing.Size(291, 366);
            this.PanelChattingPage.TabIndex = 2;
            // 
            // UCChattingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelChattingPage);
            this.Controls.Add(this.PanelWrite);
            this.Name = "UCChattingPage";
            this.Size = new System.Drawing.Size(300, 500);
            this.PanelWrite.ResumeLayout(false);
            this.PanelWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelWrite;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TBWrite;
        private System.Windows.Forms.Panel PanelChattingPage;
    }
}
