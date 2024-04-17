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

        void Send()
        {

        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 8192];
                    client.Receive(data);
                    userName.Text = Encoding.UTF8.GetString(data);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string str)
        {

        }

        byte[] Serialize(object obj)
        {
            byte[] data = Encoding.ASCII.GetBytes((string)obj);
            return data;
        }

        object Deserialize(byte[] data)
        {
            string base64ImageRepresentation = Convert.ToBase64String(data);
            Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)));
            return img;
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
    }
}
