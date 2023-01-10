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
    public partial class Form_luyentap : Form
    {
        DataRow dt;
        public Form_luyentap(DataRow row)
        {
            InitializeComponent();
            dt = row;
        }
        int num_page;
        DataProvider provider = new DataProvider();
        private void de45p_dethi_trove_Click(object sender, EventArgs e)
        {
            de45p_panel_dethi.Visible = false;
            de45p_dethi_cmthoten.Text = "";
            de45p_dethi_cmtcamnghi.Text = "";
            flowLayoutPanelXephang.Controls.Clear();
        }
        int flag_de = 0;
        int timePlay = 2700;
        string[] strdapan = new string[99];
        string[] strtraloi = new string[99];
        private void Dapan(int flag)
        {
            string path = Application.StartupPath + "\\Thi\\De" + flag.ToString();
            StreamReader srdapan = new StreamReader(path + "\\DAPAN.TXT");
            string line;
            for (int i = 1; i < 31; i++)
            {
                strdapan[i] = (line = srdapan.ReadLine());
            }
        }
        private void de45p_button_de1_Click(object sender, EventArgs e)
        {
            flag_de = 1;
            de45p_dethi_made.Text = de45p_label_de11.Text;
            de45p_dethi_hocki.Text = "1";
            de45p_dethi_dokho.Text = de45p_label_de12.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de1.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_button_de2_Click(object sender, EventArgs e)
        {
            flag_de = 2;
            de45p_dethi_made.Text = de45p_label_de21.Text;
            de45p_dethi_hocki.Text = "1";
            de45p_dethi_dokho.Text = de45p_label_de22.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de2.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_button_de3_Click(object sender, EventArgs e)
        {
            flag_de = 3;
            de45p_dethi_made.Text = de45p_label_de31.Text;
            de45p_dethi_hocki.Text = "1";
            de45p_dethi_dokho.Text = de45p_label_de32.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de3.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_button_de4_Click(object sender, EventArgs e)
        {
            flag_de = 4;
            de45p_dethi_made.Text = de45p_label_de41.Text;
            de45p_dethi_hocki.Text = "2";
            de45p_dethi_dokho.Text = de45p_label_de42.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de4.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_button_de5_Click(object sender, EventArgs e)
        {
            flag_de = 5;
            de45p_dethi_made.Text = de45p_label_de51.Text;
            de45p_dethi_hocki.Text = "2";
            de45p_dethi_dokho.Text = de45p_label_de52.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de5.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_button_de6_Click(object sender, EventArgs e)
        {
            flag_de = 6;
            de45p_dethi_made.Text = de45p_label_de61.Text;
            de45p_dethi_hocki.Text = "2";
            de45p_dethi_dokho.Text = de45p_label_de62.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de6.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;
            AddCamNghi(flag_de);
            xephang(flag_de);
        }

        private void de45p_dethi_start_Click(object sender, EventArgs e)
        {
            de45p_panel_thi.Visible = true;
            de45p_panel_dethi.Visible = false;
            num_page = 1;
            timer1.Start();
            Dapan(flag_de);
            AddPage(flag_de);

        }
        private void AddPage(int flag)
        {
            string path = Application.StartupPath + "\\Thi\\De" + flag.ToString()+"\\trang"+num_page.ToString()+".png";
            Bitmap pic = new Bitmap(path); pictureBoxDe.Image = pic;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            de45p_panel_thi.Visible = false;
        }

        private void de45p_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void de45p_dethi_ok_Click(object sender, EventArgs e)
        {
            string sqlcmd = "INSERT INTO DANHGIA"+flag_de.ToString()+"(NAME_CUS, CMT) VALUES('"+de45p_dethi_cmthoten.Text+"','"+de45p_dethi_cmtcamnghi.Text+"')";
            provider.excuteNonquery(sqlcmd);
            MessageBox.Show("Cam on da neu cam nghi.");
            AddCamNghi(flag_de);
        }
        private Panel creatPnl(DataRow dt)
        {
            //createName
            Label lblName = new Label();
            lblName.AutoSize = true;

            lblName.Name = "label48";
            lblName.Size = new System.Drawing.Size(59, 24);
            lblName.TabIndex = 0;
            lblName.Text = "Ten: "+dt[1].ToString();
            //createCamNghi
            Label lblCamNghi = new Label();
            lblCamNghi.AutoSize = true;

            lblCamNghi.Name = "label49";
            lblCamNghi.Size = new System.Drawing.Size(102, 24);
            lblCamNghi.TabIndex = 1;
            lblCamNghi.Text = dt[2].ToString();
            //createPanel
            Panel pnl = new Panel();
            pnl.AutoScroll = true;
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblCamNghi);
            pnl.Location = new System.Drawing.Point(3, 3);
            pnl.Name = "panel3";
            pnl.Size = new System.Drawing.Size(424, 145);
            pnl.TabIndex = 0;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new System.Drawing.Point(5, 10);
            lblCamNghi.Location = new System.Drawing.Point(5, 46);
            return pnl;
        }
        private void AddCamNghi(int flag)
        {
            flowLayoutPanelDanhGia.Controls.Clear();
            string sqlcmd = "SELECT * FROM DANHGIA" + flag.ToString();
            DataTable dt = provider.excuteQuery(sqlcmd);
            foreach(DataRow row in dt.Rows)
            {
                flowLayoutPanelDanhGia.Controls.Add(creatPnl(row));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num_page < 3)
            {
                num_page += 1;
                AddPage(flag_de);
                labelPage.Text = num_page.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num_page > 1)
            {
                num_page -= 1;
                AddPage(flag_de);
                labelPage.Text = num_page.ToString();
            }
        }
        private void Check()
        {
            strtraloi[1] = textBox1.Text;
            strtraloi[2] = textBox2.Text;
            strtraloi[3] = textBox3.Text;
            strtraloi[4] = textBox4.Text;
            strtraloi[5] = textBox5.Text;
            strtraloi[6] = textBox6.Text;
            strtraloi[7] = textBox7.Text;
            strtraloi[8] = textBox8.Text;
            strtraloi[9] = textBox9.Text;
            strtraloi[10] = textBox10.Text;
            strtraloi[11] = textBox20.Text;
            strtraloi[12] = textBox19.Text;
            strtraloi[13] = textBox18.Text;
            strtraloi[14] = textBox17.Text;
            strtraloi[15] = textBox16.Text;
            strtraloi[16] = textBox15.Text;
            strtraloi[17] = textBox14.Text;
            strtraloi[18] = textBox13.Text;
            strtraloi[19] = textBox12.Text;
            strtraloi[20] = textBox11.Text;
            strtraloi[21] = textBox30.Text;
            strtraloi[22] = textBox29.Text;
            strtraloi[23] = textBox28.Text;
            strtraloi[24] = textBox27.Text;
            strtraloi[25] = textBox26.Text;
            strtraloi[26] = textBox25.Text;
            strtraloi[27] = textBox24.Text;
            strtraloi[28] = textBox23.Text;
            strtraloi[29] = textBox22.Text;
            strtraloi[30] = textBox21.Text;
        }
        private void re()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
        }
        private void Result()
        {
            Check();
            timer1.Stop();
            labelResult.Text = chamdiem().ToString();
            panelResult.Visible = true;
            labelTime.Text = ((2700-timePlay)/60).ToString()+":"+ ((2700 - timePlay) % 60).ToString();
            timePlay = 2700;
            re();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Result();
        }
        private int chamdiem()
        {
            int score = 0;
            for (int i = 1; i < 31; i++)
            {
                if (strtraloi[i] == strdapan[i]) { score += 1; }
            }
            return score;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timePlay -= 1;
            label44.Text = (timePlay / 60).ToString() + ":" + (timePlay % 60).ToString();
            if (timePlay == 0)
            {
                Result();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            panelResult.Visible = false;
            de45p_panel_thi.Visible = false;
            string sqlcmd = "INSERT INTO XEPHANG" + flag_de.ToString() + "(NAME_CUS,CLASS,SCHOOL, SCORE,TIME_PLAY)" +
                " VALUES('" +dt[1].ToString() + "','" + dt[2].ToString()+ "','"+dt[3].ToString()+"','"+labelResult.Text+"','"+labelTime.Text+"')";
            provider.excuteNonquery(sqlcmd);
            xephang(flag_de);
        }
        private Panel Addxephang(DataRow dt)
        {
            //name
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Name = "label48";
            lblName.Size = new System.Drawing.Size(74, 25);
            lblName.TabIndex = 0;
            lblName.Text = dt[1].ToString();
            //lblClass
            Label lblClass = new Label();
            lblClass.AutoSize = true;
            lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClass.Name = "label50";
            lblClass.Size = new System.Drawing.Size(79, 25);
            lblClass.TabIndex = 1;
            lblClass.Text = dt[2].ToString();
            //lblSchool
            Label lblSchool = new Label();
            lblSchool.AutoSize = true;
            lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSchool.Name = "label51";
            lblSchool.Size = new System.Drawing.Size(74, 25);
            lblSchool.TabIndex = 2;
            lblSchool.Text = dt[3].ToString();
            //lblScore
            Label tmp = new Label();
            tmp.AutoSize = true;
            tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tmp.Name = "label52";
            tmp.Size = new System.Drawing.Size(68, 25);
            tmp.TabIndex = 3;
            tmp.Text = "Điểm:";

            Label lblScore = new Label();
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblScore.Name = "label54";
            lblScore.Size = new System.Drawing.Size(36, 25);
            lblScore.TabIndex = 5;
            lblScore.Text = dt[4].ToString();
            //lblTime
            Label lblTime = new Label();
            lblTime.AutoSize = true;
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.Name = "label53";
            lblTime.Size = new System.Drawing.Size(67, 25);
            lblTime.TabIndex = 4;
            lblTime.Text = dt[5].ToString();
            //pnl
            Panel pnl = new Panel();
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblClass);
            pnl.Controls.Add(lblSchool);
            pnl.Controls.Add(lblScore);
            pnl.Controls.Add(lblTime);
            pnl.Controls.Add(tmp);
            pnl.Location = new System.Drawing.Point(3, 3);
            pnl.Name = "panel3";
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Size = new System.Drawing.Size(477, 125);
            pnl.TabIndex = 0;
            lblName.Location = new System.Drawing.Point(28, 18);
            lblClass.Location = new System.Drawing.Point(130, 18);
            lblSchool.Location = new System.Drawing.Point(230, 18);
            tmp.Location = new System.Drawing.Point(28, 69);
            lblScore.Location = new System.Drawing.Point(100, 69);
            lblTime.Location = new System.Drawing.Point(230, 73);
            return pnl;
        }
        private void xephang(int flag)
        {
            flowLayoutPanelXephang.Controls.Clear();
            string sqlcmd = "SELECT * FROM XEPHANG" + flag.ToString()+ " ORDER BY SCORE, TIME_PLAY DESC";
            DataTable dt = provider.excuteQuery(sqlcmd);
            foreach(DataRow row in dt.Rows)
            {
                flowLayoutPanelXephang.Controls.Add(Addxephang(row));
            }
        }
    }
}
