﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiki
{
    public partial class Form_kiemtra : Form
    {
        int num_ques = 1;
        public Form_kiemtra()
        {
            InitializeComponent();
        }

        private void lythuyet_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[] strdapan = new string[99];
        string[] strTraLoi = new string[99];
        private void dapan(int flag)
        {
            string path = Application.StartupPath + "\\LuyenTap\\Chuong" + flag_chuong.ToString() + "\\DAPAN.txt";
            StreamReader srdapan = new StreamReader(path);
            string line;
            for (int i = 1; i <4 ; i++)
            {
                strdapan[i] = (line = srdapan.ReadLine());
            }
        }
        //kiem tra cac nut da duoc bam chua
        int flag_tracnghiem;
        int flag_tuluan;
        int flag_chuong = 0;
        private void Form_kiemtra_Load(object sender, EventArgs e)
        {
            flag_tracnghiem = 0;
            flag_tuluan = 0;
            flag_chuong = 0;

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
            if((flag_tracnghiem + flag_tuluan == 0) || (flag_chuong == 0))
            {
                MessageBox.Show("Vui chon day du hinh thuc va chuong ma ban muon kiem tra");
            }
            else
            {
                //bat dau kiem tra
                panelKtra.Visible = true;
                dapan(flag_chuong);
                AddQues(num_ques);
            }
        }
        private void AddQues(int tmp)
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            string path = Application.StartupPath+"\\LuyenTap\\Chuong"+flag_chuong.ToString()+"\\Cau"+tmp.ToString();
            Bitmap pic = new Bitmap(path + "\\ques.png"); pictureBoxQues.Image = pic;
            Bitmap pic1 = new Bitmap(path + "\\ans.png"); pictureBoxAns.Image = pic1;
            Bitmap pic2 = new Bitmap(path + "\\hint.png"); pictureBoxQues.Image = pic2;

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
            if(flag_chuong != 1)
            {
                ktra_button_chuong1.BackColor = Color.Red;
                flag_chuong = 1;
                ktra_button_chuong2.BackColor = Color.Green;
                ktra_button_chuong3.BackColor = Color.Green;
                ktra_button_chuong4.BackColor = Color.Green;
                ktra_button_chuong5.BackColor = Color.Green;
                ktra_button_allchuong.BackColor = Color.Green;
            }
        }

        private void ktra_button_chuong2_Click(object sender, EventArgs e)
        {
            if (flag_chuong != 2)
            {
                ktra_button_chuong2.BackColor = Color.Red;
                flag_chuong = 2;

                ktra_button_chuong1.BackColor = Color.Green;
                ktra_button_chuong3.BackColor = Color.Green;
                ktra_button_chuong4.BackColor = Color.Green;
                ktra_button_chuong5.BackColor = Color.Green;
                ktra_button_allchuong.BackColor = Color.Green;
            }
        }

        private void ktra_button_chuong3_Click(object sender, EventArgs e)
        {
            if (flag_chuong != 3)
            {
                ktra_button_chuong3.BackColor = Color.Red;
                flag_chuong = 3;
                ktra_button_chuong2.BackColor = Color.Green;
                ktra_button_chuong1.BackColor = Color.Green;
                ktra_button_chuong4.BackColor = Color.Green;
                ktra_button_chuong5.BackColor = Color.Green;
                ktra_button_allchuong.BackColor = Color.Green;
            }
        }

        private void ktra_button_chuong4_Click(object sender, EventArgs e)
        {
            if (flag_chuong != 4)
            {
                ktra_button_chuong4.BackColor = Color.Red;
                flag_chuong = 4;
                ktra_button_chuong2.BackColor = Color.Green;
                ktra_button_chuong3.BackColor = Color.Green;
                ktra_button_chuong1.BackColor = Color.Green;
                ktra_button_chuong5.BackColor = Color.Green;
                ktra_button_allchuong.BackColor = Color.Green;
            }
        }

        private void ktra_button_chuong5_Click(object sender, EventArgs e)
        {
            if (flag_chuong != 5)
            {
                ktra_button_chuong5.BackColor = Color.Red;
                flag_chuong = 5;

                ktra_button_chuong2.BackColor = Color.Green;
                ktra_button_chuong3.BackColor = Color.Green;
                ktra_button_chuong4.BackColor = Color.Green;
                ktra_button_chuong1.BackColor = Color.Green;
                ktra_button_allchuong.BackColor = Color.Green;
            }
        }

        private void ktra_button_allchuong_Click(object sender, EventArgs e)
        {
            if (flag_chuong != 6)
            {
                ktra_button_allchuong.BackColor = Color.Red;
                flag_chuong = 6;
                ktra_button_chuong2.BackColor = Color.Green;
                ktra_button_chuong3.BackColor = Color.Green;
                ktra_button_chuong4.BackColor = Color.Green;
                ktra_button_chuong5.BackColor = Color.Green;
                ktra_button_chuong1.BackColor = Color.Green;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked==false && radioButtonB.Checked== false && radioButtonC.Checked == false && radioButtonD.Checked == false)
            {
                MessageBox.Show("Vui long chon dap an");
            }
            else
            {
                if (radioButtonA.Checked == true) { strTraLoi[num_ques] = "A"; }
                else if (radioButtonB.Checked == true){ strTraLoi[num_ques] = "B"; }
                else if (radioButtonC.Checked == true) { strTraLoi[num_ques] = "C"; }
                else { strTraLoi[num_ques] = "D"; }
                num_ques += 1;
                if (num_ques > 3)
                {
                    LabelScore.Text = chamdiem().ToString();
                }
                else { AddQues(num_ques); }
            }
        }
        private int chamdiem()
        {
            int score = 0;
            for(int i = 1; i < 4; i++)
            {
                if (strTraLoi[i] == strdapan[i]) { score += 1; }
            }
            return score;
        }
    }
}
