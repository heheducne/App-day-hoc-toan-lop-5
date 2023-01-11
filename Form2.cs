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
    public partial class Form_lythuyet : Form
    {
        public Form_lythuyet()
        {
            InitializeComponent();
        }
        private void PicLyThuyet(string name)
        {
            flowLayoutPanel1.Controls.Clear();
            //picture 
            string path = Application.StartupPath + "\\LyThuyet\\" + name + ".png";
            Bitmap pic = new Bitmap(path);
            //create pictureBox
            PictureBox picture = new PictureBox();
            picture.Image = pic;
            picture.Location = new System.Drawing.Point(3, 3);
            picture.Name = "picture";
            picture.Size = new System.Drawing.Size(925, 3424);
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picture.TabIndex = 0;
            picture.TabStop = false;
            flowLayoutPanel1.Controls.Add(picture);
            lythuyet_label_top.Text = "LÝ THUYẾT";
            lythuyet_label_top.Font = new Font("Font Microsoft Sans Serif", 48, FontStyle.Bold);

        }
        int check_baihoc = 0;
        private void panel2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            PicLyThuyet("khainiemphanso");
            lythuyet_label_top.Text = label1.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 1;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            PicLyThuyet("sosanhphanso");
            lythuyet_label_top.Text = label3.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 2;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            PicLyThuyet("phansothapphan");
            pictureBox4.Visible = true;
            lythuyet_label_top.Text = label4.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 3;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congtruphanso");
            pictureBox5.Visible = true;
            lythuyet_label_top.Text = label5.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 4;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanchiaphanso");
            pictureBox6.Visible = true;
            lythuyet_label_top.Text = label7.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 5;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            PicLyThuyet("honso");
            pictureBox7.Visible = true;
            lythuyet_label_top.Text = label8.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 6;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            PicLyThuyet("bosunggiaitoan");
            pictureBox8.Visible = true;
            lythuyet_label_top.Text = label9.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 7;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvidodai");
            pictureBox9.Visible = true;
            lythuyet_label_top.Text = label11.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 8;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvikhoiluong");
            pictureBox10.Visible = true;
            lythuyet_label_top.Text = label12.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 9;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            PicLyThuyet("damhm");
            pictureBox11.Visible = true;
            lythuyet_label_top.Text = label13.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 10;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            PicLyThuyet("mm");
            pictureBox12.Visible = true;
            lythuyet_label_top.Text = label14.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 11;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            PicLyThuyet("khainiemsothapphan");
            pictureBox13.Visible = true;
            lythuyet_label_top.Text = label15.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 12;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            PicLyThuyet("docvietsothapphan");
            pictureBox14.Visible = true;
            lythuyet_label_top.Text = label18.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 13;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            PicLyThuyet("sosanhsothapphan");
            pictureBox15.Visible = true;
            lythuyet_label_top.Text = label19.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 14;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dodaisothapphan");
            pictureBox16.Visible = true;
            lythuyet_label_top.Text = label20.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 15;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            PicLyThuyet("khoiluongsothapphan");
            pictureBox17.Visible = true;
            lythuyet_label_top.Text = label21.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 16;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichsothapphan");
            pictureBox18.Visible = true;
            lythuyet_label_top.Text = label22.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 17;
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congsothapphan");
            pictureBox19.Visible = true;
            lythuyet_label_top.Text = label23.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 18;
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            PicLyThuyet("trusothapphan");
            pictureBox20.Visible = true;
            lythuyet_label_top.Text = label29.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 19;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoitunhien");
            pictureBox21.Visible = true;
            lythuyet_label_top.Text = label30.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 20;
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoi10");
            pictureBox22.Visible = true;
            lythuyet_label_top.Text = label31.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 21;
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoithapphan");
            pictureBox23.Visible = true;
            lythuyet_label_top.Text = label32.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 22;
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanvoitunhien");
            pictureBox24.Visible = true;
            lythuyet_label_top.Text = label33.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 23;
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanvoi10");
            pictureBox25.Visible = true;
            lythuyet_label_top.Text = label34.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 24;
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiatunhienchotunhienthuonglathapphan");
            pictureBox26.Visible = true;
            lythuyet_label_top.Text = label35.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 25;
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiatunhienchothapphan");
            pictureBox27.Visible = true;
            lythuyet_label_top.Text = label36.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 26;
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanchothapphan");
            pictureBox28.Visible = true;
            lythuyet_label_top.Text = label37.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 27;
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            PicLyThuyet("tisophantram");
            pictureBox29.Visible = true;
            lythuyet_label_top.Text = label38.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 28;
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhtamgiac");
            pictureBox30.Visible = true;
            lythuyet_label_top.Text = label40.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 29;
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhthang");
            pictureBox31.Visible = true;
            lythuyet_label_top.Text = label41.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 30;
        }

        private void panel32_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhtron");
            pictureBox32.Visible = true;
            lythuyet_label_top.Text = label42.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 31;
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichhinhtron");
            pictureBox33.Visible = true;
            lythuyet_label_top.Text = label43.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 32;
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            PicLyThuyet("luyentaptinhdientich");
            pictureBox34.Visible = true;
            lythuyet_label_top.Text = label44.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 33;
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hopchunhat");    
            pictureBox35.Visible = true;
            lythuyet_label_top.Text = label45.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 34;
        }

        private void panel36_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichhopchunhat");
            pictureBox36.Visible = true;
            lythuyet_label_top.Text = label46.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 35;
        }

        private void panel37_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dirntichlapphuong");
            pictureBox37.Visible = true;
            lythuyet_label_top.Text = label47.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 36;
        }

        private void panel38_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetich");
            pictureBox38.Visible = true;
            lythuyet_label_top.Text = label48.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 37;
        }

        private void panel39_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetichhopchunhat");
            pictureBox39.Visible = true;
            lythuyet_label_top.Text = label49.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 38;
        }

        private void panel40_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetichlapphuong");
            pictureBox40.Visible = true;
            lythuyet_label_top.Text = label50.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 39;
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvidothoigian");
            pictureBox41.Visible = true;
            lythuyet_label_top.Text = label55.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 40;
        }

        private void panel42_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congthoigian");
            pictureBox42.Visible = true;
            lythuyet_label_top.Text = label56.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 41;
        }

        private void panel43_Click(object sender, EventArgs e)
        {
            PicLyThuyet("truthoigian");
            pictureBox43.Visible = true;
            lythuyet_label_top.Text = label57.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 42;
        }

        private void panel44_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthoigianchomotso");
            pictureBox44.Visible = true;
            lythuyet_label_top.Text = label58.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 43;
        }

        private void panel45_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathoigianchomotso");
            pictureBox45.Visible = true;
            lythuyet_label_top.Text = label59.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 44;
        }

        private void panel46_Click(object sender, EventArgs e)
        {
            PicLyThuyet("vantoc");
            pictureBox46.Visible = true;
            lythuyet_label_top.Text = label60.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 45;
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            PicLyThuyet("quangduong");
            pictureBox47.Visible = true;
            lythuyet_label_top.Text = label61.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 46;
        }

        private void panel48_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thoigian");
            pictureBox48.Visible = true;
            lythuyet_label_top.Text = label62.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 47;
        }

        private void panel49_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontapveso");
            pictureBox49.Visible = true;
            lythuyet_label_top.Text = label64.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 48;
        }

        private void panel50_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontappheptinh");
            pictureBox50.Visible = true;
            lythuyet_label_top.Text = label65.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 49;
        }

        private void panel51_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontaphinhhoc");
            pictureBox51.Visible = true;
            lythuyet_label_top.Text = label66.Text;
            lythuyet_label_top.Font = new Font("Microsoft Sans Serif", 20);
            check_baihoc = 50;
        }

        private void lythuyet_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lythuyet_pictureBox_danhdau_Click(object sender, EventArgs e)
        {
            switch (check_baihoc)
            {
                case 1:
                    if (panel2.BackColor == Color.LightSteelBlue)
                        panel2.BackColor = Color.LightPink;
                    else
                        panel2.BackColor = Color.LightSteelBlue;
                    break;

                case 2:
                    if (panel3.BackColor == Color.LightSteelBlue)
                        panel3.BackColor = Color.LightPink;
                    else
                        panel3.BackColor = Color.LightSteelBlue;
                    break;

                case 3:
                    if (panel4.BackColor == Color.LightSteelBlue)
                        panel4.BackColor = Color.LightPink;
                    else
                        panel4.BackColor = Color.LightSteelBlue;
                    break;

                case 4:
                    if (panel5.BackColor == Color.LightSteelBlue)
                        panel5.BackColor = Color.LightPink;
                    else
                        panel5.BackColor = Color.LightSteelBlue;
                    break;

                case 5:
                    if (panel6.BackColor == Color.LightSteelBlue)
                        panel6.BackColor = Color.LightPink;
                    else
                        panel6.BackColor = Color.LightSteelBlue;
                    break;

                case 6:
                    if (panel7.BackColor == Color.LightSteelBlue)
                        panel7.BackColor = Color.LightPink;
                    else
                        panel7.BackColor = Color.LightSteelBlue;
                    break;

                case 7:
                    if (panel8.BackColor == Color.LightSteelBlue)
                        panel8.BackColor = Color.LightPink;
                    else
                        panel8.BackColor = Color.LightSteelBlue;
                    break;

                case 8:
                    if (panel9.BackColor == Color.LightSteelBlue)
                        panel9.BackColor = Color.LightPink;
                    else
                        panel9.BackColor = Color.LightSteelBlue;
                    break;

                case 9:
                    if (panel10.BackColor == Color.LightSteelBlue)
                        panel10.BackColor = Color.LightPink;
                    else
                        panel10.BackColor = Color.LightSteelBlue;
                    break;

                case 10:
                    if (panel11.BackColor == Color.LightSteelBlue)
                        panel11.BackColor = Color.LightPink;
                    else
                        panel11.BackColor = Color.LightSteelBlue;
                    break;

                case 11:
                    if (panel12.BackColor == Color.LightSteelBlue)
                        panel12.BackColor = Color.LightPink;
                    else
                        panel12.BackColor = Color.LightSteelBlue;
                    break;

                case 12:
                    if (panel13.BackColor == Color.LightSteelBlue)
                        panel13.BackColor = Color.LightPink;
                    else
                        panel13.BackColor = Color.LightSteelBlue;
                    break;

                case 13:
                    if (panel14.BackColor == Color.LightSteelBlue)
                        panel14.BackColor = Color.LightPink;
                    else
                        panel14.BackColor = Color.LightSteelBlue;
                    break;

                case 14:
                    if (panel15.BackColor == Color.LightSteelBlue)
                        panel15.BackColor = Color.LightPink;
                    else
                        panel15.BackColor = Color.LightSteelBlue;
                    break;

                case 15:
                    if (panel16.BackColor == Color.LightSteelBlue)
                        panel16.BackColor = Color.LightPink;
                    else
                        panel16.BackColor = Color.LightSteelBlue;
                    break;

                case 16:
                    if (panel17.BackColor == Color.LightSteelBlue)
                        panel17.BackColor = Color.LightPink;
                    else
                        panel17.BackColor = Color.LightSteelBlue;
                    break;

                case 17:
                    if (panel18.BackColor == Color.LightSteelBlue)
                        panel18.BackColor = Color.LightPink;
                    else
                        panel18.BackColor = Color.LightSteelBlue;
                    break;

                case 18:
                    if (panel19.BackColor == Color.LightSteelBlue)
                        panel19.BackColor = Color.LightPink;
                    else
                        panel19.BackColor = Color.LightSteelBlue;
                    break;

                case 19:
                    if (panel20.BackColor == Color.LightSteelBlue)
                        panel20.BackColor = Color.LightPink;
                    else
                        panel20.BackColor = Color.LightSteelBlue;
                    break;

                case 20:
                    if (panel21.BackColor == Color.LightSteelBlue)
                        panel21.BackColor = Color.LightPink;
                    else
                        panel21.BackColor = Color.LightSteelBlue;
                    break;

                case 21:
                    if (panel22.BackColor == Color.LightSteelBlue)
                        panel22.BackColor = Color.LightPink;
                    else
                        panel22.BackColor = Color.LightSteelBlue;
                    break;

                case 22:
                    if (panel23.BackColor == Color.LightSteelBlue)
                        panel23.BackColor = Color.LightPink;
                    else
                        panel23.BackColor = Color.LightSteelBlue;
                    break;

                case 23:
                    if (panel24.BackColor == Color.LightSteelBlue)
                        panel24.BackColor = Color.LightPink;
                    else
                        panel24.BackColor = Color.LightSteelBlue;
                    break;

                case 24:
                    if (panel25.BackColor == Color.LightSteelBlue)
                        panel25.BackColor = Color.LightPink;
                    else
                        panel25.BackColor = Color.LightSteelBlue;
                    break;

                case 25:
                    if (panel26.BackColor == Color.LightSteelBlue)
                        panel26.BackColor = Color.LightPink;
                    else
                        panel26.BackColor = Color.LightSteelBlue;
                    break;

                case 26:
                    if (panel27.BackColor == Color.LightSteelBlue)
                        panel27.BackColor = Color.LightPink;
                    else
                        panel27.BackColor = Color.LightSteelBlue;
                    break;

                case 27:
                    if (panel28.BackColor == Color.LightSteelBlue)
                        panel28.BackColor = Color.LightPink;
                    else
                        panel28.BackColor = Color.LightSteelBlue;
                    break;

                case 28:
                    if (panel29.BackColor == Color.LightSteelBlue)
                        panel29.BackColor = Color.LightPink;
                    else
                        panel29.BackColor = Color.LightSteelBlue;
                    break;

                case 29:
                    if (panel30.BackColor == Color.LightSteelBlue)
                        panel30.BackColor = Color.LightPink;
                    else
                        panel30.BackColor = Color.LightSteelBlue;
                    break;

                case 30:
                    if (panel31.BackColor == Color.LightSteelBlue)
                        panel31.BackColor = Color.LightPink;
                    else
                        panel31.BackColor = Color.LightSteelBlue;
                    break;

                case 31:
                    if (panel32.BackColor == Color.LightSteelBlue)
                        panel32.BackColor = Color.LightPink;
                    else
                        panel32.BackColor = Color.LightSteelBlue;
                    break;

                case 32:
                    if (panel33.BackColor == Color.LightSteelBlue)
                        panel33.BackColor = Color.LightPink;
                    else
                        panel33.BackColor = Color.LightSteelBlue;
                    break;

                case 33:
                    if (panel34.BackColor == Color.LightSteelBlue)
                        panel34.BackColor = Color.LightPink;
                    else
                        panel34.BackColor = Color.LightSteelBlue;
                    break;

                case 34:
                    if (panel35.BackColor == Color.LightSteelBlue)
                        panel35.BackColor = Color.LightPink;
                    else
                        panel35.BackColor = Color.LightSteelBlue;
                    break;

                case 35:
                    if (panel36.BackColor == Color.LightSteelBlue)
                        panel36.BackColor = Color.LightPink;
                    else
                        panel36.BackColor = Color.LightSteelBlue;
                    break;

                case 36:
                    if (panel37.BackColor == Color.LightSteelBlue)
                        panel37.BackColor = Color.LightPink;
                    else
                        panel37.BackColor = Color.LightSteelBlue;
                    break;

                case 37:
                    if (panel38.BackColor == Color.LightSteelBlue)
                        panel38.BackColor = Color.LightPink;
                    else
                        panel38.BackColor = Color.LightSteelBlue;
                    break;

                case 38:
                    if (panel39.BackColor == Color.LightSteelBlue)
                        panel39.BackColor = Color.LightPink;
                    else
                        panel39.BackColor = Color.LightSteelBlue;
                    break;

                case 39:
                    if (panel40.BackColor == Color.LightSteelBlue)
                        panel40.BackColor = Color.LightPink;
                    else
                        panel40.BackColor = Color.LightSteelBlue;
                    break;

                case 40:
                    if (panel41.BackColor == Color.LightSteelBlue)
                        panel41.BackColor = Color.LightPink;
                    else
                        panel41.BackColor = Color.LightSteelBlue;
                    break;

                case 41:
                    if (panel42.BackColor == Color.LightSteelBlue)
                        panel42.BackColor = Color.LightPink;
                    else
                        panel42.BackColor = Color.LightSteelBlue;
                    break;

                case 42:
                    if (panel43.BackColor == Color.LightSteelBlue)
                        panel43.BackColor = Color.LightPink;
                    else
                        panel43.BackColor = Color.LightSteelBlue;
                    break;

                case 43:
                    if (panel44.BackColor == Color.LightSteelBlue)
                        panel44.BackColor = Color.LightPink;
                    else
                        panel44.BackColor = Color.LightSteelBlue;
                    break;

                case 44:
                    if (panel45.BackColor == Color.LightSteelBlue)
                        panel45.BackColor = Color.LightPink;
                    else
                        panel45.BackColor = Color.LightSteelBlue;
                    break;

                case 45:
                    if (panel46.BackColor == Color.LightSteelBlue)
                        panel46.BackColor = Color.LightPink;
                    else
                        panel46.BackColor = Color.LightSteelBlue;
                    break;

                case 46:
                    if (panel47.BackColor == Color.LightSteelBlue)
                        panel47.BackColor = Color.LightPink;
                    else
                        panel47.BackColor = Color.LightSteelBlue;
                    break;

                case 47:
                    if (panel48.BackColor == Color.LightSteelBlue)
                        panel48.BackColor = Color.LightPink;
                    else
                        panel48.BackColor = Color.LightSteelBlue;
                    break;

                case 48:
                    if (panel49.BackColor == Color.LightSteelBlue)
                        panel49.BackColor = Color.LightPink;
                    else
                        panel49.BackColor = Color.LightSteelBlue;
                    break;

                case 49:
                    if (panel50.BackColor == Color.LightSteelBlue)
                        panel50.BackColor = Color.LightPink;
                    else
                        panel50.BackColor = Color.LightSteelBlue;
                    break;

                case 50:
                    if (panel51.BackColor == Color.LightSteelBlue)
                        panel51.BackColor = Color.LightPink;
                    else
                        panel51.BackColor = Color.LightSteelBlue;
                    break;


            }
        }
    }
}
