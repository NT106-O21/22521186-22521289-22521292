using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class _7_FormDangKy : Form
    {
        public _7_FormDangKy()
        {
            InitializeComponent();


        }

        public class postData
        {
            public string username { get; set; }
            public string password { get; set; }
            public postData() { }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            string mail = email.Text;
            string fname = first_name.Text;
            string lname = last_name.Text;
            int s = Int32.Parse(sex.Text);

            DateTime dateTime = birthdayPicker.Value;
            string birth = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();

            string lang = language.Text;
            string number = phone.Text;

            HttpClient client = new HttpClient();

            var jsonObject = new JObject
            {
                { "username", user },
                { "email", mail },
                { "password", pass },
                { "first_name", fname },
                { "last_name", lname },
                { "sex", s },
                { "birthday", birth },
                { "language", lang },
                { "phone", number }
            };

            string jsonString = jsonObject.ToString();
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {
                // Send POST request
                HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);

                // Read the response content as string
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Parse and handle the response as needed
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}\n{responseBody}");
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
