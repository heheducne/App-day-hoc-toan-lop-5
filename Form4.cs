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
    public partial class Form_kiemtra : Form
    {
        public Form_kiemtra()
        {
            InitializeComponent();
        }

        private void lythuyet_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_main f1 = new Form_main();
            f1.ShowDialog();
        }
        //kiem tra cac nut da duoc bam chua
        int flag_tracnghiem;
        int flag_tuluan;
        int flag_chuong1;
        int flag_chuong2;
        int flag_chuong3;
        int flag_chuong4;
        int flag_chuong5;
        int flag_allchuong;
        private void Form_kiemtra_Load(object sender, EventArgs e)
        {
            flag_tracnghiem = 0;
            flag_tuluan = 0;
            flag_chuong1 = 0;
            flag_chuong2 = 0;
            flag_chuong3 = 0;
            flag_chuong4 = 0;
            flag_chuong5 = 0;
            flag_allchuong = 0;

            ktra_button_tuluan.BackColor = Color.Green;
            ktra_button_tracnghiem.BackColor = Color.Green;
            ktra_button_chuong1.BackColor = Color.Green;
            ktra_button_chuong2.BackColor = Color.Green;
            ktra_button_chuong3.BackColor = Color.Green;
            ktra_button_chuong4.BackColor = Color.Green;
            ktra_button_chuong5.BackColor = Color.Green;
            ktra_button_allchuong.BackColor = Color.Green;

        }

        private void ktra_button_batdaulambai_Click(object sender, EventArgs e)
        {
            //kiem tra user da chon du 2 been chua (hinh thuc + chuong)
            if((flag_tracnghiem + flag_tuluan == 0) || (flag_chuong1 + flag_chuong2 + flag_chuong3 + flag_chuong4 + flag_chuong5 + flag_allchuong == 0))
            {
                MessageBox.Show("Vui chon day du hinh thuc va chuong ma ban muon kiem tra");
            }
            else
            {
                //bat dau kiem tra
            }
        }

        private void ktra_button_tracnghiem_Click(object sender, EventArgs e)
        {
            if(flag_tracnghiem == 0)
            { 
                ktra_button_tracnghiem.BackColor = Color.Red;
                flag_tracnghiem = 1;

                ktra_button_tuluan.BackColor = Color.Green;
                flag_tuluan = 0;
            } 
        }

        private void ktra_button_tuluan_Click(object sender, EventArgs e)
        {
            if (flag_tuluan == 0)
            {
                ktra_button_tuluan.BackColor = Color.Red;
                flag_tuluan = 1;

                ktra_button_tracnghiem.BackColor = Color.Green;
                flag_tracnghiem = 0;
            }
        }

        private void ktra_button_chuong1_Click(object sender, EventArgs e)
        {
            if(flag_chuong1 == 0)
            {
                ktra_button_chuong1.BackColor = Color.Red;
                flag_chuong1 = 1;

                ktra_button_chuong2.BackColor = Color.Green;
                flag_chuong2 = 0;
                ktra_button_chuong3.BackColor = Color.Green;
                flag_chuong3 = 0;
                ktra_button_chuong4.BackColor = Color.Green;
                flag_chuong4 = 0;
                ktra_button_chuong5.BackColor = Color.Green;
                flag_chuong5 = 0;
                ktra_button_allchuong.BackColor = Color.Green;
                flag_allchuong = 0;
            }
        }

        private void ktra_button_chuong2_Click(object sender, EventArgs e)
        {
            if (flag_chuong2 == 0)
            {
                ktra_button_chuong2.BackColor = Color.Red;
                flag_chuong2 = 1;

                ktra_button_chuong1.BackColor = Color.Green;
                flag_chuong1 = 0;
                ktra_button_chuong3.BackColor = Color.Green;
                flag_chuong3 = 0;
                ktra_button_chuong4.BackColor = Color.Green;
                flag_chuong4 = 0;
                ktra_button_chuong5.BackColor = Color.Green;
                flag_chuong5 = 0;
                ktra_button_allchuong.BackColor = Color.Green;
                flag_allchuong = 0;
            }
        }

        private void ktra_button_chuong3_Click(object sender, EventArgs e)
        {
            if (flag_chuong3 == 0)
            {
                ktra_button_chuong3.BackColor = Color.Red;
                flag_chuong3 = 1;

                ktra_button_chuong2.BackColor = Color.Green;
                flag_chuong2 = 0;
                ktra_button_chuong1.BackColor = Color.Green;
                flag_chuong1 = 0;
                ktra_button_chuong4.BackColor = Color.Green;
                flag_chuong4 = 0;
                ktra_button_chuong5.BackColor = Color.Green;
                flag_chuong5 = 0;
                ktra_button_allchuong.BackColor = Color.Green;
                flag_allchuong = 0;
            }
        }

        private void ktra_button_chuong4_Click(object sender, EventArgs e)
        {
            if (flag_chuong4 == 0)
            {
                ktra_button_chuong4.BackColor = Color.Red;
                flag_chuong4 = 1;

                ktra_button_chuong2.BackColor = Color.Green;
                flag_chuong2 = 0;
                ktra_button_chuong3.BackColor = Color.Green;
                flag_chuong3 = 0;
                ktra_button_chuong1.BackColor = Color.Green;
                flag_chuong1 = 0;
                ktra_button_chuong5.BackColor = Color.Green;
                flag_chuong5 = 0;
                ktra_button_allchuong.BackColor = Color.Green;
                flag_allchuong = 0;
            }
        }

        private void ktra_button_chuong5_Click(object sender, EventArgs e)
        {
            if (flag_chuong5 == 0)
            {
                ktra_button_chuong5.BackColor = Color.Red;
                flag_chuong5 = 1;

                ktra_button_chuong2.BackColor = Color.Green;
                flag_chuong2 = 0;
                ktra_button_chuong3.BackColor = Color.Green;
                flag_chuong3 = 0;
                ktra_button_chuong4.BackColor = Color.Green;
                flag_chuong4 = 0;
                ktra_button_chuong1.BackColor = Color.Green;
                flag_chuong1 = 0;
                ktra_button_allchuong.BackColor = Color.Green;
                flag_allchuong = 0;
            }
        }

        private void ktra_button_allchuong_Click(object sender, EventArgs e)
        {
            if (flag_allchuong == 0)
            {
                ktra_button_allchuong.BackColor = Color.Red;
                flag_allchuong = 1;

                ktra_button_chuong2.BackColor = Color.Green;
                flag_chuong2 = 0;
                ktra_button_chuong3.BackColor = Color.Green;
                flag_chuong3 = 0;
                ktra_button_chuong4.BackColor = Color.Green;
                flag_chuong4 = 0;
                ktra_button_chuong5.BackColor = Color.Green;
                flag_chuong5 = 0;
                ktra_button_chuong1.BackColor = Color.Green;
                flag_chuong1 = 0;
            }
        }

    }
}
