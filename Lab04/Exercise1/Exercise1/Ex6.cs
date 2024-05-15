using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;

namespace Lab04
{
    public partial class Ex6 : Form
    {
        public string Data { get; set; }
        private static readonly HttpClient client = new HttpClient();

        public Ex6()
        {
            InitializeComponent();
        }

        private void Ex6_Load(object sender, EventArgs e)
        {
            string[] data = Data.Split(" ");
            txtboxAccessToken.Text = data[0];
            txtboxTokenType.Text = data[1];
        }

        private async void btnViewDetail_Click(object sender, EventArgs e)
        {
            string accessToken = txtboxAccessToken.Text.Trim();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://nt106.uitiot.vn/api/v1/user/me");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var json = JObject.Parse(responseBody);

                id.Text = json["id"].ToString();
                username.Text = json["username"].ToString();
                email.Text = json["email"].ToString();
                first_name.Text = json["first_name"].ToString();
                last_name.Text = json["last_name"].ToString();
                sex.Text = json["sex"].ToString();
                birthday.Text = json["birthday"].ToString();
                language.Text = json["language"].ToString();
                phone.Text = json["phone"].ToString();
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
