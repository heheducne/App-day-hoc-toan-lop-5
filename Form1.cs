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
        DataProvider provider = new DataProvider();
        Form_lythuyet f1 = new Form_lythuyet();
        public Form_main()
        {
            InitializeComponent();
            cbAdd();
        }
        private void cbAdd()
        {
            main_comboBox_ho_va_ten.Items.Clear();
            DataTable dt = provider.excuteQuery("SELECT * FROM dbo.ACCOUNT");
            foreach (DataRow row in dt.Rows)
            {
                main_comboBox_ho_va_ten.Items.Add(row[1].ToString());
            }
        }
        //button chưa có thông tin
        private void button2_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = true;
            main_textBox_ten.Text = "";
            main_textBox_lop.Text = "";
            main_textBox_truong.Text = "";
            main_panel_ho_va_ten.Visible = false;
        }
        //button đồng ý tạo học sinh mới
        private void button1_Click(object sender, EventArgs e)
        {
            if (main_textBox_lop.Text == "" || main_textBox_ten.Text == "" || main_textBox_truong.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin");
            }
            else
            {
                main_panel_taohocsinhmoi.Visible = false;
                main_panel_ho_va_ten.Visible = true;
                string sqlcmd = "INSERT INTO dbo.ACCOUNT (NAME_STUDENT,CLASS,SCHOOL)  VALUES ('"+main_textBox_ten.Text+
                                   "', '"+main_textBox_lop.Text+
                                   "', '"+main_textBox_truong.Text+"');";
                //MessageBox.Show(sqlcmd);
                provider.excuteNonquery(sqlcmd);
                MessageBox.Show("Them hoc sinh thanh cong");
                cbAdd();
            }
        }
        //button hiện form lý thuyết
        private void main_pictureBox_lythuyet_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void main_pictureBox_luyentap_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitAdd_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = false;
        }

        private void main_comboBox_ho_va_ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM dbo.ACCOUNT WHERE NAME_STUDENT = '"+main_comboBox_ho_va_ten.Text+"'";
            DataRow dt = provider.excuteQuery(sqlcmd).Rows[0];
            main_label_lop.Text = dt[3].ToString();
            main_label_truong.Text = dt[2].ToString();
        }

        private void main_pictureBox_kiemtra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_kiemtra f1 = new Form_kiemtra();
            f1.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            main_pictureBox_kiemtra.Visible = true;
            main_pictureBox_luyentap.Visible = true;
            main_pictureBox_lythuyet.Visible = true;

            main_panel_taohocsinhmoi.Visible = false;
            main_panel_ho_va_ten.Visible = false;

            main_pictureBox_bear1.Visible = true;
            main_pictureBox_bear2.Visible = true;
            main_pictureBox_bear3.Visible = true;
        }

        private void main_pictureBox_start_Click(object sender, EventArgs e)
        {
            main_panel_ho_va_ten.Visible = true;
            main_pictureBox_start.Visible = false;
        }

        private void main_pictureBox_user_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            main_pictureBox_kiemtra.Visible = false;
            main_pictureBox_luyentap.Visible = false;
            main_pictureBox_lythuyet.Visible = false;

            main_panel_taohocsinhmoi.Visible = false;
            main_panel_ho_va_ten.Visible = true;

            main_pictureBox_bear1.Visible = false;
            main_pictureBox_bear2.Visible = false;
            main_pictureBox_bear3.Visible = false;
        }

        private void main_pictureBox_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên thực hiện:\r\n Bùi Hữu Đức - 20520449\r\n Cao Khắc Tuân - 20520841\r\n JAN-2023","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
