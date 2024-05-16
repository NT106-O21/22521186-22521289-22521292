using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _7_FormDangNhap : Form
    {
        private Ex7 mainForm;

        public _7_FormDangNhap(Ex7 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            _7_FormDangKy dangky = new _7_FormDangKy();
            dangky.ShowDialog();
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string password = pass.Text;

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            });

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", content);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = JObject.Parse(responseBody);
                        string accessToken = jsonResponse["access_token"]?.ToString();
                        string name = jsonResponse["user"]["username"]?.ToString();

                        mainForm.SetAccessToken(accessToken);
                        mainForm.SetName(name);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}\n{responseBody}");
                    }
                }
            }
            catch (HttpRequestException httpRequestException)
            {
                MessageBox.Show($"Error: {httpRequestException.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
