using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            HNAG_Client client = new HNAG_Client();
            client.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            HNAG_Server server = new HNAG_Server();
            server.Show();
        }
    }
}
