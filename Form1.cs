using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiki
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        //button chưa có thông tin
        private void button2_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = true;
            main_textBox_ten.Text = "";
            main_textBox_lop.Text = "";
            main_textBox_truong.Text = "";
        }
        //button đồng ý tạo học sinh mới
        private void button1_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = false;
        }
        //button hiện form lý thuyết
        private void main_pictureBox_lythuyet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_lythuyet f1 = new Form_lythuyet();
            f1.ShowDialog();
        }

        private void main_pictureBox_luyentap_Click(object sender, EventArgs e)
        {

        }
    }
}
