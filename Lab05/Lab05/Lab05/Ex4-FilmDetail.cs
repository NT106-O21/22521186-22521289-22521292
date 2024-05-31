using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Ex4_FilmDetail : Form
    {
        public Ex4_FilmDetail(string url)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.url = url;
            ShowDetail();
        }
        string url;
        private async void ShowDetail()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate(url);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
        }
    }
}
