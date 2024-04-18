using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Exercise6
{
    public partial class Receiver : Form
    {
        public Receiver()
        {
            InitializeComponent();
        }
        private Socket tcpSender;
        private Socket tcpReceiver;
        private EndPoint remote_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 10000);
        private delegate void SafeCallDelegate(string status);

        private void UpdateChatHistory(string status)
        {
            if (ChatBox.InvokeRequired)
            {
                var invoker = new SafeCallDelegate(UpdateChatHistory);
                ChatBox.Invoke(invoker, new object[] { status });
            }
            else
            {
                if (status.Contains('\n'))
                {
                    status = status.Replace('\n', ' ');
                }
                ChatBox.AppendText(status + '\n');
            }
        }
        private void Listen()
        {
            tcpSender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
            tcpSender.Bind(local_endpoint);
            tcpSender.Listen(1);
            while (true)
            {
                tcpReceiver = tcpSender.Accept();
                while (tcpReceiver.Connected)
                {
                    byte[] data = new byte[1024];
                    int byte_count = tcpReceiver.ReceiveFrom(data, ref remote_endpoint);
                    if (byte_count == 0)
                    {
                        break;
                    }
                    Packet receivedData = new Packet(data);
                    string status = "";
                    status = "";
                    switch (receivedData.ChatDataIdentifier)
                    {
                        case DataIdentifier.LogIn:
                            status = $"-- Now, you can talk to {receivedData.ChatName} --";
                            break;

                        case DataIdentifier.LogOut:
                            status = $"-- {receivedData.ChatName} has left --";
                            break;

                        case DataIdentifier.Message:
                            status = $"{receivedData.ChatName}: {receivedData.ChatMessage}";
                            break;
                        case DataIdentifier.File:
                            status = $"-- {receivedData.ChatName} has sent you a file --";
                            DialogResult dr = MessageBox.Show("Do you want to read it now?",
                                                      "",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                            {
                                MessageBox.Show(receivedData.ChatMessage);
                            }
                            break;
                    }
                    UpdateChatHistory(status);
                }
            }
        }

        private void Receiver_Load(object sender, EventArgs e)
        {
            Thread senderThread = new Thread(new ThreadStart(Listen));
            senderThread.Start();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Packet sendData = null;
            string file_message = "";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        StreamReader sr = new StreamReader(fs);
                        file_message = sr.ReadToEnd();
                    }
                    sendData = new Packet()
                    {
                        ChatDataIdentifier = DataIdentifier.File,
                        ChatName = this.Text,
                        ChatMessage = file_message
                    };
                }
                byte[] data = sendData.GetDataStream();
                tcpReceiver.SendTo(data, remote_endpoint);
                UpdateChatHistory($"-- You have sent a file {ofd.FileName}");
            }
            catch
            {
                MessageBox.Show("Please choose a file!");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Message,
                    ChatName = this.Text,
                    ChatMessage = txtSendBox.Text
                };
                byte[] data = sendData.GetDataStream();
                tcpReceiver.SendTo(data, remote_endpoint);
                UpdateChatHistory($"Me: {txtSendBox.Text}");
                txtSendBox.Clear();
            }
            catch
            {
                tcpSender.Close();
            }
        }
    }
}
