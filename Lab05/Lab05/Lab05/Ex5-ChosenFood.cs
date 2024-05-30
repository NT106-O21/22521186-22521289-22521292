using Newtonsoft.Json;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab05
{
    public partial class Ex5_ChosenFood : Form
    {
        private Ex5 mainForm;

        private string accessToken;
        private int chosenid;

        public Ex5_ChosenFood(Ex5 mainForm, string accessToken, int chosenID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.accessToken = accessToken;
            this.chosenid = chosenID;

            LoadChosenFood(chosenid);
        }
        private async Task LoadChosenFood(int id)
        {
            HttpClient client = new HttpClient();
            string url = "https://nt106.uitiot.vn/api/v1/monan/" + id.ToString();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);


            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(responseBody);

                FoodItem food = JsonConvert.DeserializeObject<FoodItem>(responseBody);
                foodView1.SetFoodItem(food);
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

        private bool isconfig = false;

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (isconfig == false)
            {
                Ex5_EmailConfigForm form = new Ex5_EmailConfigForm(this);
                form.ShowDialog();
            }
        }

        public void SetConfigStatus(bool status)
        {
            isconfig = status;
        }
    }
}
