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

namespace Exercise6
{
    public partial class Receiver : Form
    {
        public Receiver()
        {
            InitializeComponent();
        }

        private static Socket tcpReceiver;
        private EndPoint remote_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
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
        private void Receive()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int byte_count = tcpReceiver.ReceiveFrom(data, ref remote_endpoint);
                if (byte_count == 0)
                {
                    break;
                }
                Packet receivedData = new Packet(data);
                if (receivedData.ChatDataIdentifier == DataIdentifier.Message)
                {
                    UpdateChatHistory($"{receivedData.ChatName}: {receivedData.ChatMessage}");
                }
                if (receivedData.ChatDataIdentifier == DataIdentifier.LogOut)
                {
                    UpdateChatHistory($"-- {receivedData.ChatName} has left --");
                }
                if (receivedData.ChatDataIdentifier == DataIdentifier.File)
                {
                    UpdateChatHistory($"-- {receivedData.ChatName} has sent you a file --");
                    DialogResult dr = MessageBox.Show("Do you want to read it now?",
                                                      "",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show(receivedData.ChatMessage);
                    }
                }
            }
        }

        private void Receiver_Load(object sender, EventArgs e)
        {
            tcpReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 12000);
            tcpReceiver.Bind(local_endpoint);
            try
            {
                tcpReceiver.Connect(remote_endpoint);
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.LogIn,
                    ChatName = this.Text,
                    ChatMessage = ""
                };
                byte[] login_message = sendData.GetDataStream();
                tcpReceiver.SendTo(login_message, remote_endpoint);
                Thread youThread = new Thread(Receive)
                {
                    IsBackground = true
                };
                youThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSendBox.Text))
            {
                MessageBox.Show("Please type something!");
                return;
            }
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
                MessageBox.Show("Connection has failed!");
            }
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

        private void Receiver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.LogOut,
                ChatName = this.Text.Trim(),
                ChatMessage = ""
            };
            byte[] logout_message = sendData.GetDataStream();
            tcpReceiver.SendTo(logout_message, remote_endpoint);
            tcpReceiver.Shutdown(SocketShutdown.Send);
        }
    }
}
