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
    public partial class Form_luyentap : Form
    {
        public Form_luyentap()
        {
            InitializeComponent();
        }

        private void de45p_dethi_trove_Click(object sender, EventArgs e)
        {
            de45p_panel_dethi.Visible = false;
            de45p_dethi_cmthoten.Text = "";
            de45p_dethi_cmtcamnghi.Text = "";
        }
        int flag_de = 0;
        private void de45p_button_de1_Click(object sender, EventArgs e)
        {
            flag_de = 1;
            de45p_dethi_made.Text = de45p_label_de11.Text;
            de45p_dethi_hocki.Text = "1";
            de45p_dethi_dokho.Text = de45p_label_de12.Text;
            de45p_dethi_button.BackgroundImage = de45p_button_de1.BackgroundImage;
            //cmt chua co
            de45p_panel_dethi.Visible = true;

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
        }

        private void de45p_dethi_start_Click(object sender, EventArgs e)
        {
            de45p_panel_thi.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            de45p_panel_thi.Visible = false;
        }

        private void de45p_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
