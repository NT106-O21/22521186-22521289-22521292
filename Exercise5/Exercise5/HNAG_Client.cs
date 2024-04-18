using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml.Linq;
using System.Text.Encodings.Web;

namespace Exercise5
{
    public partial class HNAG_Client : Form
    {
        public HNAG_Client()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            foodImage2.Visible = false;

            Connect();
        }

        IPEndPoint IP;
        Socket client;
        List<CommunityFood> foodList = new List<CommunityFood>();
        int bytelength = 0;
        byte[] storagedata = new byte[1024 * 5000];

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server !!!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    bytelength = client.Receive(data);
                    storagedata = data;

                    SetFoodList();
                }
            }
            catch
            {
                Close();
            }
        }

        private void HNAG_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (Path.GetExtension(ofd.FileName) == ".png")
            {
                foodImage2.Text = Path.GetFileName(ofd.FileName);
                foodImage2.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file ảnh .png !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            if (userName.Text.Trim() != "" && foodName2.Text.Trim() != "" && foodImage2.Text.Trim() != "")
            {
                string path = Path.Combine(projectDirectory, foodImage2.Text.Trim());
                CommunityFood food = new CommunityFood(foodName2.Text.Trim(), userName.Text.Trim(), path);
                foodList.Add(food);

                var jsonSetting = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string jsonstring = JsonSerializer.Serialize(food, jsonSetting);

                byte[] bytes = Encoding.UTF8.GetBytes(jsonstring);

                client.Send(bytes);
            }
            else MessageBox.Show("Vui lòng không để ô trống !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {

        }

        void SetFoodList()
        {
            foodList.Clear();
            listView2.Clear();
            imageList2.Images.Clear();

            byte[] bytes = storagedata;
            List<byte> newBytes = new List<byte>();

            for (int i = 0; i < bytelength; i++)
            {
                newBytes.Add(bytes[i]);
            }
            byte[] newBytesArray = newBytes.ToArray();

            string a = Encoding.UTF8.GetString(newBytesArray);

            var jsonSetting = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            foodList = JsonSerializer.Deserialize<List<CommunityFood>>(a, jsonSetting);

            AddListView();
        }

        void AddListView()
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                listView2.Items.Add(foodList.ElementAt(i).FoodName);
                imageList2.Images.Add(Image.FromFile(foodList.ElementAt(i).FoodImage));
                listView2.Items[i].ImageIndex = i;
            }
        }
    }
}
