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

        }
        private void panel2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            PicLyThuyet("khainiemphanso");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            PicLyThuyet("sosanhphanso");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            PicLyThuyet("phansothapphan");
            pictureBox4.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congtruphanso");
            pictureBox5.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanchiaphanso");
            pictureBox6.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            PicLyThuyet("honso");
            pictureBox7.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            PicLyThuyet("bosunggiaitoan");
            pictureBox8.Visible = true;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvidodai");
            pictureBox9.Visible = true;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvikhoiluong");
            pictureBox10.Visible = true;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            PicLyThuyet("damhm");
            pictureBox11.Visible = true;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            PicLyThuyet("mm");
            pictureBox12.Visible = true;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            PicLyThuyet("khainiemsothapphan");
            pictureBox13.Visible = true;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            PicLyThuyet("docvietsothapphan");
            pictureBox14.Visible = true;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            PicLyThuyet("sosanhsothapphan");
            pictureBox15.Visible = true;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dodaisothapphan");
            pictureBox16.Visible = true;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            PicLyThuyet("khoiluongsothapphan");
            pictureBox17.Visible = true;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichsothapphan");
            pictureBox18.Visible = true;
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congsothapphan");
            pictureBox19.Visible = true;
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            PicLyThuyet("trusothapphan");
            pictureBox20.Visible = true;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoitunhien");
            pictureBox21.Visible = true;
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoi10");
            pictureBox22.Visible = true;
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthapphanvoithapphan");
            pictureBox23.Visible = true;
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanvoitunhien");
            pictureBox24.Visible = true;
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanvoi10");
            pictureBox25.Visible = true;
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiatunhienchotunhienthuonglathapphan");
            pictureBox26.Visible = true;
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiatunhienchothapphan");
            pictureBox27.Visible = true;
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathapphanchothapphan");
            pictureBox28.Visible = true;
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            PicLyThuyet("tisophantram");
            pictureBox29.Visible = true;
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhtamgiac");
            pictureBox30.Visible = true;
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhthang");
            pictureBox31.Visible = true;
        }

        private void panel32_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hinhtron");
            pictureBox32.Visible = true;
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichhinhtron");
            pictureBox33.Visible = true;
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            PicLyThuyet("luyentaptinhdientich");
            pictureBox34.Visible = true;
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            PicLyThuyet("hopchunhat");    
            pictureBox35.Visible = true;
        }

        private void panel36_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dientichhopchunhat");
            pictureBox36.Visible = true;
        }

        private void panel37_Click(object sender, EventArgs e)
        {
            PicLyThuyet("dirntichlapphuong");
            pictureBox37.Visible = true;
        }

        private void panel38_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetich");
            pictureBox38.Visible = true;
        }

        private void panel39_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetichhopchunhat");
            pictureBox39.Visible = true;
        }

        private void panel40_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thetichlapphuong");
            pictureBox40.Visible = true;
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            PicLyThuyet("donvidothoigian");
            pictureBox41.Visible = true;
        }

        private void panel42_Click(object sender, EventArgs e)
        {
            PicLyThuyet("congthoigian");
            pictureBox42.Visible = true;
        }

        private void panel43_Click(object sender, EventArgs e)
        {
            PicLyThuyet("truthoigian");
            pictureBox43.Visible = true;
        }

        private void panel44_Click(object sender, EventArgs e)
        {
            PicLyThuyet("nhanthoigianchomotso");
            pictureBox44.Visible = true;
        }

        private void panel45_Click(object sender, EventArgs e)
        {
            PicLyThuyet("chiathoigianchomotso");
            pictureBox45.Visible = true;
        }

        private void panel46_Click(object sender, EventArgs e)
        {
            PicLyThuyet("vantoc");
            pictureBox46.Visible = true;
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            PicLyThuyet("quangduong");
            pictureBox47.Visible = true;
        }

        private void panel48_Click(object sender, EventArgs e)
        {
            PicLyThuyet("thoigian");
            pictureBox48.Visible = true;
        }

        private void panel49_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontapveso");
            pictureBox49.Visible = true;
        }

        private void panel50_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontappheptinh");
            pictureBox50.Visible = true;
        }

        private void panel51_Click(object sender, EventArgs e)
        {
            PicLyThuyet("ontaphinhhoc");
            pictureBox51.Visible = true;
        }

        private void lythuyet_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
