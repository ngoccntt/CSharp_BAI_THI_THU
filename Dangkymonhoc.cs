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
    public partial class Dangkymonhoc : Form
    {
        public Dangkymonhoc()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin ="MSSV" + txtmssv.Text;
            thongtin +="\nHoTen" + txtHoVaTen.Text;
            thongtin +="\nNienKhoa" + cbbNienKhoa.Text;
            thongtin +="\nLop" + cbbLop.Text;
            thongtin +="\nHocky" + radioButton1.Text + radioButton2.Text + radioButton3.Text + radioButton4.Text;
            thongtin +="\nMonhoc" + checkedListBox1.Text;
            MessageBox.Show(thongtin, "Ghi chú");
        }
    }
}
