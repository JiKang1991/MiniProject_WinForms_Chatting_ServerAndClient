using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChattingClientAndServer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // UCJoin 객체를 생성합니다.
            UserControls.UCJoin uCJoin = new UserControls.UCJoin(PanelMain);

            // uCJoin의 Dock속성을 Fill로 설정합니다.
            uCJoin.Dock = DockStyle.Fill;

            // PanelMain에 uCJoin을 출력합니다.
            PanelMain.Controls.Add(uCJoin);

        }
    }
}
