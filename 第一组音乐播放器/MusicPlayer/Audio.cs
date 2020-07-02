using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Audio : Form
    {
        public Audio()
        {
            InitializeComponent();
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.ShowDialog();
        }

        private void 登陆ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

    }
}
