using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Ex5_EmailConfigForm : Form
    {
        Ex5_ChosenFood mainform;

        public Ex5_EmailConfigForm(Ex5_ChosenFood mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string imapServer = txtImapServer.Text;
            int imapPort = int.Parse(txtImapPort.Text);
            string smtpServer = txtSmtpServer.Text;
            int smtpPort = int.Parse(txtSmtpPort.Text);
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                using (var client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.Credentials = new NetworkCredential(username, password);
                    client.EnableSsl = true;
                    client.Send(new MailMessage(username, username, "Test Email", "This is a test email."));
                }

                mainform.SetConfigStatus(true);
                mainform.SetEmail(username);
                mainform.SetPassword(password);

                MessageBox.Show("Kết nối tới Email Server thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới Email Server! Vui lòng kiểm tra lại cài đặt.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainform.SetConfigStatus(false);
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
