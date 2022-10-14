using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stt1.Text = "Giải phương trình bậc 2";
            GiaiPT t = new GiaiPT();
            t.ShowDialog();
            stt1.Text = "Ready!";
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tachTen f = new tachTen();
            f.ShowDialog();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator f = new calculator();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            clock f = new clock();
            f.ShowDialog();
        }

        private void giảiPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stt1.Text = "Giải phương trình bậc 2";
            GiaiPT t = new GiaiPT();
            t.ShowDialog();
            stt1.Text = "Ready!";
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            stt1.Text = "Giải phương trình bậc 2";
            GiaiPT t = new GiaiPT();    
            t.ShowDialog();
            stt1.Text = "Ready!";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stt3.Text = "Thời gian hệ thống: " + System.DateTime.Now.ToString();
        }

        private void danhMucHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
