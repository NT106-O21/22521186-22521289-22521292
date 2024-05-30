using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Ex5_InviteForm : Form
    {
        Ex5_ChosenFood mainForm;
        private string email = "";
        private string password = "";
        private FoodItem food = new FoodItem();

        public Ex5_InviteForm(Ex5_ChosenFood mainForm, string email, string password, FoodItem food)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.email = email;
            this.password = password;
            this.food = food;
            foodView1.SetFoodItem(food);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtEmail.Text);
            txtEmail.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string subject = "Bạn có một lời mời đi ăn";
            string htmlBody = $@"
            <html>
            <body>
                <h2>{food.ten_mon_an}</h2>
                <p>Giá: {food.gia}</p>
                <p>Địa chỉ: {food.dia_chi}</p>
                <p>Đóng góp: {food.nguoi_dong_gop}</p>
                <img src=""{food.hinh_anh}"" width=""500"" height=""300"">
            </body>
            </html>";

            foreach (string email in listBox1.Items)
            {
                SendEmail(email, subject, htmlBody);
            }

            MessageBox.Show("Emails sent successfully!");
            this.Close();
        }

        private void SendEmail(string toEmail, string subject, string htmlBody)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(email);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = htmlBody;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught in SendEmail(): {0}", ex.ToString());
            }
        }
    }
}
