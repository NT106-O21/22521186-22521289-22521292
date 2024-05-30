using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace Lab05
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        //Khai báo 
        private string url = "https://betacinemas.vn/phim.htm";
        private string filepath = "movies.html";
        private string filepath_json = "movies.json";
        private WebClient myClient = new WebClient();

        private class Movie
        {
            public string MovieName { get; set; }
            public string MovieUrl { get; set; }
            public string MovieImg { get; set; }
        }

        //DownLoad file html
        private void DownLoad()
        {
            string html = GetHTML(url);

            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, filepath);
        }

        private string GetHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream);
            string html = sr.ReadToEnd();
            response.Close();
            return html;
        }

        private void FormBT4_Load(object sender, EventArgs e)
        {
            DownLoad();
            InitialLoad();
        }

        //Lấy thông tin từ file html
        private List<Movie> GetFilm(IHtmlDocument document)
        {
            List<Movie> list = new List<Movie>();

            var rowTags = document.QuerySelectorAll("div.row");

            foreach (var rowTag in rowTags)
            {
                var nameTag = rowTag.QuerySelector("h3 > a");
                var imgTag = rowTag.QuerySelector("img");

                if (nameTag != null && imgTag != null)
                {
                    string movieName = nameTag.TextContent.Trim();
                    string movieUrl = $"https://betacinemas.vn/{nameTag.GetAttribute("href")}";
                    string movieImg = imgTag.GetAttribute("src");

                    Movie movie = new Movie()
                    {
                        MovieName = movieName,
                        MovieUrl = movieUrl,
                        MovieImg = movieImg
                    };

                    list.Add(movie);
                }
            }

            return list;
        }

        //Ghi thông tin vào file Json
        private void WriteToJson(List<Movie> list)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                string jsonString = JsonSerializer.Serialize(list, options);

                // Ghi chuỗi JSON vào tệp với encoding UTF-8
                using (StreamWriter sw = new StreamWriter(filepath_json, false, Encoding.UTF8))
                {
                    sw.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Truy cập vào file html đã download và ghi vào file Json
        private void InitialLoad()
        {
            string htmlContent = File.ReadAllText(filepath);

            var parser = new HtmlParser();
            var document = parser.ParseDocument(htmlContent);

            List<Movie> movies = GetFilm(document);

            WriteToJson(movies);

            DisplayFilm(movies);
        }

        //Hiểm thị danh sách phim
        private void DisplayFilm(List<Movie> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!");
            }
            else
            {
                foreach (Movie movie in list)
                {
                    //Tạo Panel
                    Panel panel = new Panel();
                    panel.Size = new System.Drawing.Size(658, 164);

                    //Xác định vị trí mặc định của panel
                    if (panel_listfilm.Controls.Count > 0)
                    {
                        Panel lastPanel = (Panel)panel_listfilm.Controls[panel_listfilm.Controls.Count - 1];
                        panel.Top = lastPanel.Bottom + 10; // Vị trí Y của panel mới là vị trí dưới cùng của panel trước đó cộng với một khoảng trống (10 pixel)
                    }

                    //Thêm panel vào panel_listfilm
                    panel_listfilm.Controls.Add(panel);

                    //Nội dung Panel
                    Ex4_Display form = new Ex4_Display(movie.MovieName, movie.MovieUrl, movie.MovieImg);
                    form.Dock = DockStyle.Fill;
                    panel.Controls.Add(form);
                    panel.Tag = form;
                    form.BringToFront();
                    form.Show();

                    //Hiệu ứng di chuột vào panel
                    panel.MouseEnter += (sender, e) =>
                    {
                        panel.BackColor = Color.Blue;
                    };
                }
            }
        }
    }
}
