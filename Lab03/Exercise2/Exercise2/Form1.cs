using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThread = new Thread(new ThreadStart(StartUnsafeThread));
            ServerThread.Start();
        }

        private void StartUnsafeThread()
        {
            int byteReceived = 0;
            byte[] recv = new byte[1024];
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("192.168.56.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(1);
            btnListen.Enabled = false;
            clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add(new ListViewItem("New Client Connected"));
            while (clientSocket.Connected)
            {
                string text = " ";
                do
                {
                    byteReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                    listViewCommand.Items.Add(new ListViewItem(text));
                } while (text[text.Length - 1] != '\n');
                listenerSocket.Close();
            }
        }
    }
}
