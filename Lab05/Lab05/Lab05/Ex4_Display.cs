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

namespace Lab05
{
    public partial class Ex4_Display : UserControl
    {
        public Ex4_Display(string name, string url, string img)
        {
            InitializeComponent();
            LoadLabel(name, url);
            LoadImg(img);
            GetUrl(url);
        }

        private string url_film;

        private void LoadLabel(string name, string url)
        {
            label_name.Text = name;
            label_link.Text = url;
        }

        private void LoadImg(string img_url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imgBytes = webClient.DownloadData($"{img_url}");

                    using (var ms = new System.IO.MemoryStream(imgBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pictureBox_film.Image = img;
                        pictureBox_film.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong truy cap dc");
            }
        }

        private void GetUrl(string url)
        {
            url_film = url;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            Ex4_Detail f = new Ex4_Detail(url_film);
            f.Show();
        }
    }
}
