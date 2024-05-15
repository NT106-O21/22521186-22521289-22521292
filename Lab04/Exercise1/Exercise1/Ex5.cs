using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _7_FormDangKy dangKy = new _7_FormDangKy();
            dangKy.ShowDialog();
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string password = pass.Text;
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            });
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", formContent);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var json = JObject.Parse(responseBody);
                string accessToken = json["access_token"].ToString();
                string tokenType = json["token_type"].ToString();

                txtboxData.Text = "access_token = " + accessToken + Environment.NewLine + "token_type = " + tokenType;
                txtboxData.Text += Environment.NewLine + Environment.NewLine + "Đăng nhập thành công";
                Ex6 ex6 = new Ex6();
                ex6.Data = accessToken + " " + tokenType;
                ex6.Show();
            }
            catch (HttpRequestException httpRequestException)
            {
                txtboxData.Text = $"Error: {httpRequestException.Message}";
                txtboxData.Text += Environment.NewLine + Environment.NewLine + "Đăng nhập thất bại";
            }
        }
    }
}
