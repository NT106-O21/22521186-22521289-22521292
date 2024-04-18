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
    public partial class Server : Form
    {
        private static int port;

        public Server()
        {
            InitializeComponent();
        }
        UdpClient server;
        IPEndPoint ipEndPoint;
        

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                server = new UdpClient(int.Parse(txtPortBox.Text));
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(txtPortBox.Text) - 1000);
                server.BeginReceive(new AsyncCallback(onReceive), server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = server.EndReceive(AR, ref ipEndPoint);
            server.BeginReceive(new AsyncCallback(onReceive), server);
            ControlInvoke(txtSentContent, () => txtSentContent.AppendText("127.0.0.1: " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }
        delegate void UniversalVoidDelegate();
        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing) return;
            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }
    }
}
