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
    public partial class Ex4_UserControl : UserControl
    {
        public Ex4_UserControl()
        {
            InitializeComponent();
        }
        public void setLabel(string label)
        {
            this.Title.Text = label;
        }
        public void setImg(string url)
        {
            this.pictureBox1.Load(url);
        }
        public void setURL(string url)
        {
            this.URL.Text = url;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ex4_Server a = new Ex4_Server();
            a.Show();
        }

        private void Ex4_UserControl_Click(object sender, EventArgs e)
        {
            Ex4_FilmDetail a = new(URL.Text);
            a.Show();
        }
    }
}
