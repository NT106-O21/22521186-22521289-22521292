using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab04
{
    public partial class _7_FormAdd : Form
    {
        private Ex7 mainForm;

        private string accessToken;

        public _7_FormAdd(Ex7 mainForm, string access_token)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            accessToken = access_token;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foodname.Text = string.Empty;
            price.Text = string.Empty;
            address.Text = string.Empty;
            picture.Text = string.Empty;
            description.Text = string.Empty;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            string ten = foodname.Text;
            int gia = 0;
            if (price.Text != "")
                gia = Int32.Parse(price.Text);
            string mo_ta = description.Text;
            string hinh = picture.Text;
            string dia_chi = address.Text;

            var jsonObject = new JObject
            {
                { "ten_mon_an", ten },
                { "gia", gia },
                { "mo_ta", mo_ta },
                { "hinh_anh", hinh },
                { "dia_chi", dia_chi },
            };

            string jsonString = jsonObject.ToString();
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/add", content);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        //form1.AddFoodToList(foodName);
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
