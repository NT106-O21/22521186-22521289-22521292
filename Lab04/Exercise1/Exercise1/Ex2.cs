using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            myClient.DownloadFile(txtUrl.Text, txtPath.Text);

            StreamReader sr = new StreamReader(txtPath.Text);
            rtbOutput.Text = sr.ReadToEnd();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.ShowDialog();
            txtPath.Text = openFileDialog.SelectedPath + "\\" + "contentDowload";
        }
    }
}
