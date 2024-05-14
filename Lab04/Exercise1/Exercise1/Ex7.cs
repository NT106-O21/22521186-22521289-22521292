using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net;
using static Lab04._7_FormDangKy;
using System.Security.Policy;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Lab04
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _7_FormDangKy dangky = new _7_FormDangKy();
            dangky.ShowDialog();
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
                // Send POST request
                HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", formContent);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read response content as string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var json = JObject.Parse(responseBody);
                string accessToken = json["access_token"].ToString();
                string tokenType = json["token_type"].ToString();

                // Print the access_token and token_type to TextBox1
                textBox1.Text = "AccessToken = " + accessToken + Environment.NewLine + "TokenType = " + tokenType;
            }
            catch (HttpRequestException httpRequestException)
            {
                // Handle exception
                textBox1.Text = $"Error: {httpRequestException.Message}";
            }
        }
    }
}
