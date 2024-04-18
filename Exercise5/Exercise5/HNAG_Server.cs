using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Text.Encodings.Web;

namespace Exercise5
{
    public partial class HNAG_Server : Form
    {
        public HNAG_Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            SetDefaultFoodList();

            Connect();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList = new List<Socket>();

        List<CommunityFood> foodList = new List<CommunityFood>();
        int bytelength = 0;
        byte[] storagedata = new byte[1024 * 5000];

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int count = 0;

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(1000);
                        Socket client = server.Accept();    

                        clientList.Add(client);
                        count++;
                        AddMessage("Client_" + count.ToString() + " đã tham gia kênh");

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                        SendFoodList();
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        void Receive(object obj)
        {
            Socket c = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    bytelength = c.Receive(data);
                    storagedata = data;

                    AddNewFood();
                }
            }
            catch
            {
                clientList.Remove(c);
                c.Close();
            }
        }

        void AddMessage(string str)
        {
            reportBox.Items.Add(str);
        }

        private void HNAG_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            listView1.SelectedItems[0].Remove();
            foodList.RemoveAt(index);
            AddMessage("Server đã xóa một món ăn");

            SendFoodList();
        }

        void SetDefaultFoodList()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string path = Path.Combine(projectDirectory, listView1.Items[i].ImageKey);
                CommunityFood food = new CommunityFood(listView1.Items[i].Text, "Server", path);
                foodList.Add(food);
            }
        }

        void SendFoodList()
        {
            var jsonSetting = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonstring = JsonSerializer.Serialize(foodList, jsonSetting);

            byte[] bytes = Encoding.UTF8.GetBytes(jsonstring);
            
            foreach (Socket item in clientList)
            {
                item.Send(bytes);
            }
        }

        void AddNewFood()
        {
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
            CommunityFood food = JsonSerializer.Deserialize<CommunityFood>(a, jsonSetting);
            foodList.Add(food);

            listView1.Items.Add(food.FoodName);

            imageList1.Images.Add(Image.FromFile(food.FoodImage));
            listView1.Items[listView1.Items.Count - 1].ImageIndex = imageList1.Images.Count - 1;

            AddMessage(food.UserName + " đã thêm món ăn mới");
            SendFoodList();
        }
    }
}
