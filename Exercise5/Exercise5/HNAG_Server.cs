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

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();

                        clientList.Add(client);
                        AddMessage("Client mới đã tham gia kênh");

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8090);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes("hello");
            client.Send(data);
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string str)
        {
        }

        byte[] Serialize(object obj)
        {
            return (byte[])obj;
        }

        object Deserialize(byte[] data)
        {
            string text = Encoding.ASCII.GetString(data);
            return text;
        }

        private void HNAG_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }

        void SetDefaultFoodList()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string path = Path.Combine(projectDirectory, listView1.Items[i].ImageKey);
                CommunityFood food = new CommunityFood(listView1.Items[i].Text, "Server", Image.FromFile(path));
                foodList.Add(food);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            reportBox.Items.Add(foodList.Count);
        }
    }
}
