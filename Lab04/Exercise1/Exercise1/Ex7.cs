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
using Newtonsoft.Json;
using System.Collections.Immutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab04
{
    public partial class Ex7 : Form
    {
        private string accessToken;
        private string name;
        private List<FoodItem> communityfoodList = new List<FoodItem>();
        private List<FoodItem> personalfoodList = new List<FoodItem>();
        private int communityfoodTotal = 0;
        private int personalfoodTotal = 0;

        public Ex7()
        {
            InitializeComponent();

        }

        private async void Ex7_Load(object sender, EventArgs e)
        {
            _7_FormDangNhap loginForm = new _7_FormDangNhap(this);
            loginForm.ShowDialog();

            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Bạn cần đăng nhập để sử dụng ứng dụng.");
                this.Close();
            }

            await LoadCommunityFoodList(1, 10);

            await LoadPersonalFoodList(1, 10);

        }
        public void SetAccessToken(string token)
        {
            accessToken = token;
        }

        public void SetName(string n)
        {
            name = n;
            label2.Text = "Chào " + name + "!";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            _7_FormAdd addFoodForm = new _7_FormAdd(this, accessToken);
            addFoodForm.ShowDialog();

            pagesizeList.SelectedIndex = 0;
            currentpageList.SelectedIndex = 0;

            int pagesize = Convert.ToInt32(pagesizeList.SelectedItem.ToString());
            int current = Convert.ToInt32(currentpageList.SelectedItem.ToString());

            LoadCommunityFoodList(current, pagesize);

            LoadPersonalFoodList(current, pagesize);
        }

        private async Task LoadCommunityFoodList(int current, int pagesize)
        {
            var jsonObject = new JObject
            {
                { "current", current },
                { "pageSize", pagesize }
            };

            string jsonString = jsonObject.ToString();
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var json = JObject.Parse(responseBody);
                        string data = json["data"].ToString();
                        communityfoodList = JsonConvert.DeserializeObject<List<FoodItem>>(data);

                        int total = Int32.Parse(json["pagination"]["total"].ToString());
                        communityfoodTotal = total;

                        DisplayFoodItems(communityfoodList, flowLayoutPanel1);
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

        private async Task LoadPersonalFoodList(int current, int pagesize)
        {
            var jsonObject = new JObject
            {
                { "current", current },
                { "pageSize", pagesize }
            };

            string jsonString = jsonObject.ToString();
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/my-dishes", content);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var json = JObject.Parse(responseBody);
                        string data = json["data"].ToString();
                        personalfoodList = JsonConvert.DeserializeObject<List<FoodItem>>(data);

                        int total = Int32.Parse(json["pagination"]["total"].ToString());
                        personalfoodTotal = total;

                        DisplayFoodItems(personalfoodList, flowLayoutPanel2);
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

            Ex7 newForm = new Ex7();
            newForm.Show();
        }

        private void DisplayFoodItems(List<FoodItem> foodList, FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var foodItem in foodList)
            {
                var foodControl = new FoodView();
                foodControl.SetFoodItem(foodItem);
                flowLayoutPanel.Controls.Add(foodControl);
            }
        }

        private void pagesizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPageList();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SetPageList();
            }
            catch (Exception ex) { MessageBox.Show("Vui lòng chọn kích thước trang trước"); }
        }

        private void SetPageList()
        {
            int pagesize = Convert.ToInt32(pagesizeList.SelectedItem.ToString());

            if (tabControl1.SelectedIndex == 0)
            {
                double number = (double)communityfoodTotal / pagesize;
                double numberofPage = Math.Ceiling(number);

                currentpageList.Items.Clear();
                for (int i = 1; i < numberofPage + 1; i++)
                    currentpageList.Items.Add(i.ToString());

                currentpageList.SelectedIndex = 0;
            }
            else
            {
                double number = (double)personalfoodTotal / pagesize;
                double numberofPage = Math.Ceiling(number);

                currentpageList.Items.Clear();
                for (int i = 1; i < numberofPage + 1; i++)
                    currentpageList.Items.Add(i.ToString());

                currentpageList.SelectedIndex = 0;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            if (tabControl1.SelectedIndex == 0)
            {
                int rdSerialNumber = rd.Next(communityfoodList.Count);
                int chosenID = communityfoodList.ElementAt(rdSerialNumber).id;

                _7_ChosenFood chooseFood = new _7_ChosenFood(this, accessToken, chosenID);
                chooseFood.ShowDialog();
            }
            else
            {
                int rdSerialNumber = rd.Next(personalfoodList.Count);
                int chosenID = personalfoodList.ElementAt(rdSerialNumber).id;

                _7_ChosenFood chooseFood = new _7_ChosenFood(this, accessToken, chosenID);
                chooseFood.ShowDialog();
            }
        }

        private void currentpageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pagesize = Convert.ToInt32(pagesizeList.SelectedItem.ToString());
                int current = Convert.ToInt32(currentpageList.SelectedItem.ToString());

                LoadCommunityFoodList(current, pagesize);

                LoadPersonalFoodList(current, pagesize);
            }
            catch (Exception ex) { MessageBox.Show("Vui lòng chọn kích thước trang trước"); }
        }
    }
}
