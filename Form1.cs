using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_BAI_THI_THU
{
    public partial class frmbaithi : Form
    {
        public frmbaithi()
        {
            InitializeComponent();
        }

        private void lblInfor_Click(object sender, EventArgs e)
        {
           
        }

        private void frmbaithi_Load(object sender, EventArgs e)
        {
            string HoTenSV = "Nguyen Van A";
            string MSSV = "213454685";
            string Monthi = "Lập Trình Windows 2 C#";

            lblInfor.Text = "Họ và Tên: " + HoTenSV;
            lblInfor.Text += "\nMSSV" + MSSV;
            lblInfor.Text += "\nMonThi" + Monthi;
            lblInfor.Text += "\nTime" + System.DateTime.Now.ToString();
          
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lập trình Window!" , "Thông Tin");
        }

        private void giaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 GPTB2 = new GiaiPhuongTrinhBac2();
            GPTB2.Show();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkymonhoc dkmh = new Dangkymonhoc();
            dkmh.Show();
        }
    }
}
