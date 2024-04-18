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

namespace Exercise1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        UdpClient client;
        IPEndPoint ipEndPoint;
        //private static int remote_port = int.Parse(txtPortBox.Text);
        //int port = (int.Parse(txtPortBox.Text) - 1000);

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new UdpClient(int.Parse(txtPortBox.Text) - 1000);
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(txtPortBox.Text));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ipEndPoint);
                client.Send(Encoding.UTF8.GetBytes(txtSent.Text), txtSent.Text.Length);
            }
            catch
            {
                MessageBox.Show("Send failed! Please send again!");
            }
        }
    }
}
