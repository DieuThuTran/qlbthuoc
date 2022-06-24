using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbthuoc
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC f = new frmNCC();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKH f = new frmKH();
            f.Show();
        }

        private void thuốcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            f.Show();
        }

        private void nhómThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhomthuoc f = new frmnhomthuoc();
            f.Show();
        }
    }
}
