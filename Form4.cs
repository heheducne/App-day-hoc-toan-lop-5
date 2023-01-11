using System;
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
            for (int i = 1; i <21 ; i++)
            {
                strdapan[i] = (line = srdapan.ReadLine());
            }
        }
        //kiem tra cac nut da duoc bam chua
        int num_ques = 1;
        int flag_chuong ;
        private void Form_kiemtra_Load(object sender, EventArgs e)
        {
            flag_chuong = 0;
            ktra_button_chuong1.BackColor = Color.Green;
            ktra_button_chuong2.BackColor = Color.Green;
            ktra_button_chuong3.BackColor = Color.Green;
            ktra_button_chuong4.BackColor = Color.Green;
            ktra_button_chuong5.BackColor = Color.Green;  

            ktra_label_chuong.Visible = false;
            ktra_pictureBox2.Visible = false;
        }

        private void ktra_button_batdaulambai_Click(object sender, EventArgs e)
        {
            //kiem tra user da chon du 2 been chua (hinh thuc + chuong)
            if((flag_chuong == 0))
            {
                MessageBox.Show("Vui chon chuong ma ban muon kiem tra");
            }
            else
            {
                //bat dau kiem tra
                ktra_panel_kiemtra.Visible = true;
                dapan(flag_chuong);
                AddQues(num_ques);
                ktra_label_conclude2.Visible = false;
                ktra_label_2.Visible = false;
                ktra_pictureBox_back.Visible = false;
            }
        }
        private void AddQues(int tmp)
        {
            label4.Text = "CÂU HỎI: " + tmp.ToString() + "/20";
            flowLayoutPanel1.Visible = false;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            string path = Application.StartupPath+"\\LuyenTap\\Chuong"+flag_chuong.ToString()+"\\Cau"+tmp.ToString();
            Bitmap pic = new Bitmap(path + "\\ques.png"); pictureBoxQues.Image = pic;
            Bitmap pic1 = new Bitmap(path + "\\ans.png"); pictureBoxAns.Image = pic1;
            Bitmap pic2 = new Bitmap(path + "\\hint.png"); pictureBoxHint.Image = pic2;

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
                
                ktra_label_conclude2.Visible = true;
                ktra_label_conclude2.Text = ktra_label_chuong.Text = "Chương 1";
                ktra_label_2.Text = "Ôn tập và bổ sung về phân số. \r\nGiải toán liên quan đến tỉ lệ. \r\nBảng đơn vị đo diện tích";
                ktra_label_2.Visible = true;
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

                ktra_label_conclude2.Visible = true;
                ktra_label_conclude2.Text = ktra_label_chuong.Text = "Chương 2";
                ktra_label_2.Text = "Số thập phân. \r\nCác phép tính với số thập phân";
                ktra_label_2.Visible = true;
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

                ktra_label_conclude2.Visible = true;
                ktra_label_conclude2.Text = ktra_label_chuong.Text = "Chương 3";
                ktra_label_2.Text = "Hình học";
                ktra_label_2.Visible = true;
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

                ktra_label_conclude2.Visible = true;
                ktra_label_conclude2.Text = ktra_label_chuong.Text = "Chương 4";
                ktra_label_2.Text = "Số đo thời gian.\r\n Toán chuyển động đều";
                ktra_label_2.Visible = true;
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

                ktra_label_conclude2.Visible = true;
                ktra_label_conclude2.Text = ktra_label_chuong.Text = "Chương 5";
                ktra_label_2.Text = "Ôn tập cuối năm";
                ktra_label_2.Visible = true;
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
                if (num_ques > 20)
                {
                    panelScore.Visible = true;
                    labelScore.Text = chamdiem().ToString()+"/20";               
                }
                else { AddQues(num_ques); }
            }
        }
        private int chamdiem()
        {
            int score = 0;
            for(int i = 1; i < 21; i++)
            {
                if (strTraLoi[i] == strdapan[i]) { score += 1; }
            }
            return score;
        }

        private void ktra_button_goiy_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible == true)
            {
                flowLayoutPanel1.Visible = false;
            }
            else { flowLayoutPanel1.Visible = true; 
        }
        }

        private void pictureBoxExitpanel_Click(object sender, EventArgs e)
        {
            ktra_panel_kiemtra.Visible = false;
            ktra_label_conclude2.Visible = true;
            ktra_label_2.Visible = true;
            num_ques = 1;
            ktra_pictureBox_back.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ktra_panel_kiemtra.Visible = false;
            ktra_label_conclude2.Visible = true;
            ktra_label_2.Visible = true;
            num_ques = 1;
            panelScore.Visible = false;
        }
    }
}
