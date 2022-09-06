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
    public partial class tachTen : Form
    {
        string ht, kq;
        int vt1, vt2;
        public tachTen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            kq = ht.Substring(0, vt1);
            lblkq.Text = kq;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.IndexOf(" ");
            vt2 = ht.LastIndexOf(" ");
            kq = ht.Substring(vt1, vt2 - vt1);
            lblkq.Text = kq;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTachDemTen_Click(object sender, EventArgs e)
        {
            lblkq.Text = DemTen(txtHT.Text.Trim());
        }
        private string DemTen(string str)
        {
            vt1 = str.IndexOf(" ");
            kq = str.Substring(0, vt1);
            return kq;
        }
        private void lblkq_Click(object sender, EventArgs e)
        {

        }
        
    }
}
