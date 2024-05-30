using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Ex4_Detail : Form
    {
        public Ex4_Detail(string url)
        {
            InitializeComponent();
            LoadWebBrowser();
            LoadWebsite(url);
        }

        WebBrowser webBrowser;

        private void LoadWebBrowser()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            panel_Website.Controls.Add(webBrowser);
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void LoadWebsite(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                this.Text = url;
                webBrowser.Navigate(url);
            }    
        }
    }
}
