using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;


namespace doancuoiki
{
    public partial class Form_main : Form
    {
        DataProvider provider = new DataProvider();
        Form_lythuyet f1 = new Form_lythuyet();
        DataRow info;
        string path_macdinh = Application.StartupPath + "\\Avatar\\macdinh.jpg";
        string path ="";
        public Form_main()
        {
            InitializeComponent();
        }
        int tmp = 0;
        //button chưa có thông tin
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text==""|| textBoxAccount.Text == "" || textBoxPass.Text == "" || textBoxPass2.Text == "" || textBoxName.Text == "" || comboBoxCate.Text == "" || textBoxClass.Text == "" || textBoxSchool.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                int cate = 0;
                DataTable dt = provider.excuteQuery("SELECT * FROM dbo.ACCOUNT");
                bool tmp = dt.AsEnumerable().Any(row => textBoxAccount.Text == row.Field<String>("TDN"));
                if (tmp == true) { MessageBox.Show("Tên đăng nhập đã tồn tại"); }
                else if (textBoxPass.Text != textBoxPass2.Text) { MessageBox.Show("Mật khẩu không khớp"); }
                else
                {
                    if (comboBoxCate.Text == "Admin")
                    {
                        if (textBoxCheck.Text != "Admin") { MessageBox.Show("Mã xác thực không đúng"); }
                        else { cate = 1; }
                    }
                    if ((comboBoxCate.Text == "Admin" && cate == 1) || comboBoxCate.Text != "Admin")
                    {
                        main_panel_taohocsinhmoi.Visible = false;
                        main_panel_ho_va_ten.Visible = true;
                        string sqlcmd = "INSERT INTO dbo.ACCOUNT (TDN, NAME_STUDENT,CLASS,SCHOOL,PASS,CATE,EMAIL,IMAGE_PATH)  VALUES ('" + textBoxAccount.Text + "','" + textBoxName.Text +
                                           "', '" + textBoxClass.Text +
                                           "', '" + textBoxSchool.Text + "','" + textBoxPass.Text + "','" + cate.ToString() + "','"+textBoxEmail.Text+"','"+path_macdinh+"');";
                        //MessageBox.Show(sqlcmd);
                        provider.excuteNonquery(sqlcmd);
                        MessageBox.Show("Dang ki thanh vien thanh cong");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = true;
            main_panel_ho_va_ten.Visible = false;
            textBoxAccount.Text = "";
            textBoxPass.Text = "";
            textBoxPass2.Text = "";
            textBoxName.Text = "";
            textBoxClass.Text = "";
            textBoxSchool.Text = "";
            textBoxSchool.Text = "";
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
            this.Hide();
            Form_luyentap f4 = new Form_luyentap(info);
            f4.ShowDialog();
            this.Show();
        }

        private void buttonExitAdd_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = false;
            main_panel_ho_va_ten.Visible = true;
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
            if (main_comboBox_ho_va_ten.Text == ""||main_comboBox_ho_va_ten.Text=="")
            {
                MessageBox.Show("Vui long điền đủ thông tin");
            }
            else {
                string sqlcmd = "SELECT * FROM dbo.ACCOUNT WHERE TDN ='" + main_comboBox_ho_va_ten.Text + "' AND PASS='" +textBox1.Text + "'";
                //MessageBox.Show(sqlcmd);
                DataTable dt = provider.excuteQuery(sqlcmd);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                else
                {
                    info = dt.Rows[0];
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
                    main_pictureBox_user.Visible = true;
                    changeInfo();
                }
            }
        }
        private void changeInfo()
        {
            labelName.Text = info[1].ToString();
            labelClass.Text = info[2].ToString();
            labelSchool.Text = info[3].ToString();
            if (Int32.Parse(info[5].ToString()) == 1) { labelCate.Text = "Admin"; }
            else { labelCate.Text = "Thường"; }
            labelEmail.Text = info[6].ToString();
            Bitmap pic = new Bitmap(info[7].ToString()); pictureBoxAvt.Image = pic;
        }
        private void main_pictureBox_start_Click(object sender, EventArgs e)
        {
            main_panel_ho_va_ten.Visible = true;
            main_pictureBox_start.Visible = false;
        }

        private void main_pictureBox_user_Click(object sender, EventArgs e)
        {
            if (panelThongTin.Visible == false) { panelThongTin.Visible = true; }
            else { panelThongTin.Visible = false; }
        }

        private void main_pictureBox_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên thực hiện:\r\n Bùi Hữu Đức - 20520449\r\n Cao Khắc Tuân - 20520841\r\n JAN-2023","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_panel_taohocsinhmoi.Visible = false;
            main_panel_ho_va_ten.Visible = true;
        }

        private void buttonQuenMatKhau_Click(object sender, EventArgs e)
        {
            panelDoiMatKhau.Visible = true;
            main_panel_ho_va_ten.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM dbo.ACCOUNT WHERE TDN ='" + textBoxtdn_re.Text + "' AND EMAIL='"+textBoxEmial_re.Text+"'";
            DataTable dt = provider.excuteQuery(sqlcmd);
            if (dt.Rows.Count > 0)
            {
                info = dt.Rows[0];
                string fromMail = "tuan20520841@gmail.com";
                string fromPassword = "vktsmtdjmkfphdhc";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Khôi phục mật khẩu";
                message.To.Add(new MailAddress(textBoxEmial_re.Text));
                message.Body = "<html><body> Mật khẩu cũ:"+ info[4].ToString() +"</body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };
                smtpClient.Send(message);
                MessageBox.Show("Mật khẩu cũ đã gửi đến email bạn đã đăng kí");
                textBoxPass_re.Enabled = true;
                textBoxNewPass.Enabled = true;
                textBoxNewPass2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác");
            }
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (textBoxPass_re.Text != info[4].ToString()) { MessageBox.Show("Mật khẩu cũ không khớp" ); }
            else if (textBoxNewPass.Text == info[4].ToString()) { MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ"); }
            else
            {

                doimatkhau(textBoxNewPass.Text, textBoxNewPass2.Text, textBoxPass_re.Text, textBoxtdn_re.Text);
                textBoxPass_re.Enabled = false;
                textBoxNewPass.Enabled = false;
                textBoxNewPass2.Enabled = false;
                panelDoiMatKhau.Visible = false;
                main_panel_ho_va_ten.Visible = true;
                tmp = 0;
            }
        }
        private void doimatkhau(string NewPass1, string NewPass2, string Pass, string tdn)
        {
            MessageBox.Show(NewPass1);
            MessageBox.Show(NewPass2);
            MessageBox.Show(Pass);
            MessageBox.Show(tdn);
            if (NewPass1 != NewPass2) { MessageBox.Show("Mật khẩu mới không khớp"); }
            else
            {
                string sqlcmd = "UPDATE ACCOUNT " +
                                "SET PASS = '" + NewPass1 + "'" +
                                " WHERE TDN ='" + tdn + "'; ";
                //MessageBox.Show(sqlcmd);
                provider.excuteNonquery(sqlcmd);
                tmp = 1;
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxtdn_re.Text = "";
            textBoxEmial_re.Text = "";
            textBoxPass_re.Enabled = false;
            textBoxNewPass.Enabled = false;
            textBoxNewPass2.Enabled = false;
            panelDoiMatKhau.Visible = false;
            main_panel_ho_va_ten.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelThongTin.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelMatKhau.Visible = true;
            panelThongTin.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelMatKhau.Visible = false;
            panelThongTin.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox5.Text =="" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
            }
            else
            {
                doimatkhau(textBox5.Text, textBox4.Text, textBox6.Text, info[0].ToString());
                if (tmp == 1)
                {
                    panelMatKhau.Visible = false;
                    panelThongTin.Visible = true;
                }
                else { MessageBox.Show("Vui lòng nhập đúng thông tin"); }
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            main_pictureBox_kiemtra.Visible = false;
            main_pictureBox_luyentap.Visible = false;
            main_pictureBox_lythuyet.Visible = false;

            main_panel_taohocsinhmoi.Visible = false;
            main_panel_ho_va_ten.Visible = true;
            panelThongTin.Visible = false;
            main_pictureBox_bear1.Visible = false;
            main_pictureBox_bear2.Visible = false;
            main_pictureBox_bear3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(info[7].ToString()); pictureBoxChangeAvt.Image = pic;
            panelThongTin.Visible = false;
            panelDoiInfo.Visible = true;
            if (Int32.Parse(info[5].ToString()) == 1) { comboBoxNew.Text = "Admin"; }
            else { comboBoxNew.Text = "Thường"; }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelThongTin.Visible = true;
            panelDoiInfo.Visible = false;
            textBoxName.Text = "";
            textBoxNewCheck.Text = "";
            textBoxNewClass.Text = "";
            textBoxNewEmail.Text = "";
            textBoxNewSchool.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            OpenFileDialog ord = new OpenFileDialog();
            if (ord.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ord.FileName;
                Bitmap pic = new Bitmap(path);pictureBoxChangeAvt.Image = pic;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string NewName = info[1].ToString();
            string NewClass = info[2].ToString();
            string NewSchool = info[3].ToString();
            string NewEmail = info[6].ToString();
            if (textBoxNewName.Text != "") { NewName = textBoxNewName.Text; }
            if (textBoxNewClass.Text != "") { NewClass = textBoxNewClass.Text; }
            if (textBoxNewSchool.Text != "") { NewSchool = textBoxNewSchool.Text; }
            if (textBoxNewEmail.Text !=  "") { NewEmail = textBoxNewEmail.Text; }
                int cate = 0;
                if (comboBoxNew.Text == "Admin")
                {
                    if (textBoxNewCheck.Text != "Admin") { MessageBox.Show("Mã xác thực không đúng"); }
                    else { cate = 1; }
                }
                if ((comboBoxNew.Text == "Admin" && cate == 1) || comboBoxNew.Text != "Admin")
                {
                    panelThongTin.Visible = true;
                    panelDoiInfo.Visible = false;
                    string sqlcmd = "UPDATE dbo.ACCOUNT SET  NAME_STUDENT='" + NewName +
                                       "', CLASS='" + NewClass +
                                       "', SCHOOL='" + NewSchool + "',CATE='" + cate.ToString() + "',EMAIL='" + NewEmail + "',IMAGE_PATH='" + Application.StartupPath + "\\Avatar\\" + info[0].ToString() + ".jpg'" +
                                       " WHERE TDN='" + info[0].ToString() + "';";
                MessageBox.Show(sqlcmd);
                provider.excuteNonquery(sqlcmd);
                MessageBox.Show("Đôi thông tin thành công");
                if (path != "") {
                    File.Copy(path, Application.StartupPath + "\\Avatar\\" + info[0].ToString() + ".jpg"); path = ""; }
                sqlcmd = "SELECT * FROM dbo.ACCOUNT WHERE TDN ='" + main_comboBox_ho_va_ten.Text + "' AND PASS='" + textBox1.Text + "'";
                DataTable dt = provider.excuteQuery(sqlcmd);
                info = dt.Rows[0];
                changeInfo();
                path_macdinh = Application.StartupPath + "\\Avatar\\macdinh.jpg";
                panelThongTin.Visible = true;
                panelDoiInfo.Visible = false;
                textBoxName.Text = "";
                textBoxNewCheck.Text = "";
                textBoxNewClass.Text = "";
                textBoxNewEmail.Text = "";
                textBoxNewSchool.Text = "";
                }
        }
    }
}

