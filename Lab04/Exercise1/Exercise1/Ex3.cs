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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate(txtUrl.Text);
        }

        private void btnDownFile_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            myClient.DownloadFile(txtUrl.Text, txtPath.Text + "dowloadFile");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.ShowDialog();
            txtPath.Text = openFileDialog.SelectedPath + "\\";
        }
    }
}
