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

namespace Exercise3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
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

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytelength = client.Receive(data);
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
            client.Send(Encoding.UTF8.GetBytes("Connection accepted from " + IP.ToString()));
            btnConnect.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.Send(Encoding.UTF8.GetBytes(textBox1.Text));
            textBox1.Clear();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Send(Encoding.UTF8.GetBytes(IP.ToString() + " has disconnected"));
            client.Close();
            btnConnect.Enabled = false;
        }
    }
}
