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
    }
}
