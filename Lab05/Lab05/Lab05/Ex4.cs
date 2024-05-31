using HtmlAgilityPack;
using Newtonsoft.Json;
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
using System.Xml;

namespace Lab05
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
            DownloadHTMLFile("https://betacinemas.vn/");
            GetDetail();
            AnalyzeDetailFilm();
            AddControl();
            WriteJson();
        }
        List<Movies> movies = new List<Movies>();
        private void AddControl()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Ex4_UserControl userControl1 = new Ex4_UserControl();
                userControl1.Location = new Point(12, 12 + (160 * i));
                userControl1.setLabel(movies[i].Title);
                userControl1.setImg(movies[i].Img);
                userControl1.setURL(movies[i].Detail);
                Controls.Add(userControl1);
            }
        }
        private void DownloadHTMLFile(string url)
        {
            string filename = "HTMLFilmInput";
            WebClient wc = new WebClient();
            wc.DownloadFile(url, filename);
        }
        private void GetDetail()
        {
            string filename = "HTMLFilmInput";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            string html = new StreamReader(fs).ReadToEnd();
            fs.Close();
            doc.LoadHtml(html);

            HtmlNodeCollection htmlimgnode = doc.DocumentNode.SelectNodes("//div[@class = 'pi-img-wrapper']/img");
            HtmlNodeCollection htmlhrefnode = doc.DocumentNode.SelectNodes("//div[@class= 'film-info film-xs-info']/h3/a");
            Movies mv;
            for (int i = 0; i < htmlhrefnode.Count; i++)
            {
                mv = new Movies();
                mv.Img = htmlimgnode[i].Attributes["src"].Value;
                mv.Detail = "https://betacinemas.vn" + htmlhrefnode[i].Attributes["href"].Value;
                movies.Add(mv);
            }
        }
        private void AnalyzeDetailFilm()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlNode node;
            for (int i = 0; i < movies.Count; i++)
            {
                HtmlNode tempnode;
                HtmlNodeCollection htmlNodes;
                doc = htmlWeb.Load(movies[i].Detail);
                node = doc.DocumentNode.SelectSingleNode("//div[@class= 'col-lg-12 col-md-12 col-sm-12 col-xs-16 padding-xs-top-15']");
                tempnode = node.SelectSingleNode("//h1");
                movies[i].Title = tempnode.InnerText.Trim();
                tempnode = node.SelectSingleNode("//p");
                movies[i].Summary = tempnode.InnerText.Trim();
                htmlNodes = node.SelectNodes("//div/div[@class= 'col-lg-12 col-md-12 col-sm-12 col-xs-10']");
                movies[i].Director = htmlNodes[0].InnerText.Trim();
                movies[i].Actor = htmlNodes[1].InnerText.Trim();
                movies[i].Genre = htmlNodes[2].InnerText.Trim();
                movies[i].Time = htmlNodes[3].InnerText.Trim();
                movies[i].Language = htmlNodes[4].InnerText.Trim();
                movies[i].Showtime = htmlNodes[5].InnerText.Trim();
            }
        }
        private void WriteJson()
        {
            StreamWriter file = File.CreateText("moviesInput.Json");
            string resutl = JsonConvert.SerializeObject(movies, Newtonsoft.Json.Formatting.Indented);
            file.Write(resutl);
            file.Close();
        }
        private class Movies
        {
            public string Title { get; set; }
            public string Img { get; set; }
            public string Detail { get; set; }
            public string Genre { get; set; }
            public string Time { get; set; }
            public string Director { get; set; }
            public string Summary { get; set; }
            public string Actor { get; set; }
            public string Language { get; set; }
            public string Showtime { get; set; }

        }
    }
}
