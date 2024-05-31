using Newtonsoft.Json;
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

namespace Lab05
{
    public partial class Ex4_Server : Form
    {
        public Ex4_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Listen();
            ReadFileInput();
            ReadJson();
            ShowDataToInput();
        }
        List<Ex4_Client> clients = new List<Ex4_Client>();
        List<Socket> clientlist;
        List<Movie> movielist = new List<Movie>();
        List<MovieDetail> movieDetail = new List<MovieDetail>();
        string data;
        double ticketprice = 0;
        Socket server;
        IPEndPoint IP;
        private void Listen()
        {
            try
            {
                clientlist = new List<Socket>();
                IP = new IPEndPoint(IPAddress.Any, 1024);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(IP);

                Thread listen = new Thread(() =>
                {
                    try
                    {
                        while (true)
                        {
                            DateTime dt = DateTime.Now;
                            server.Listen(100);
                            Socket client;
                            client = server.Accept();

                            clientlist.Add(client);

                            rtbLog.Text += "Quầy " + (clientlist.Count).ToString() + " has connected" + "\n";

                            Send(client);

                            Thread receive = new Thread(() =>
                            {
                                Receive(client);
                            });
                            receive.IsBackground = true;
                            receive.Start();
                        }
                    }
                    catch (Exception e)
                    {
                        IP = new IPEndPoint(IPAddress.Any, 9999);
                        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        MessageBox.Show(e.Message);
                    }
                });
                listen.IsBackground = true;
                listen.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Listen");
                return;
            }
        }
        private void Send(Socket client)
        {
            try
            {
                client.Send(Serialize(rtbInput.Text));
            }
            catch
            {
                MessageBox.Show("Send");
            }
        }
        private void SendAll()
        {
            foreach (Socket s in clientlist)
            {
                Send(s);
            }
        }
        private void Receive(Socket client)
        {
            try
            {
                while (true)
                {
                    DateTime date = DateTime.Now;
                    string clientname = "";
                    int i = 1;

                    byte[] receive = new byte[1024 * 5000];
                    client.Receive(receive);

                    string message = (string)Deserialize(receive);
                    message = message.Trim('\0');

                    foreach (Socket s in clientlist)
                    {
                        if (s.RemoteEndPoint == client.RemoteEndPoint)
                        {
                            clientname = "Quầy " + i;
                            break;
                        }
                        i++;
                    }

                    if (message[0] == '\0') continue;
                    rtbLog.Text += date.ToString();
                    rtbLog.Text += ": " + clientname;
                    rtbLog.Text += " : ";
                    rtbLog.Text += message;
                    rtbLog.Text += "\n";

                    Reply(client, Search(message));

                    if (Search(message) == true)
                    {
                        UpdateData(message);
                    }
                    ShowDataToInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Receive");
                return;
            }
        }
        private void Reply(Socket client, bool iftrue)
        {
            string message = data;
            double ticketprice = 0;
            if (iftrue)
            {
                message += "\n" + "Successfully Purchased";
                message += "\n" + ticketprice;
            }
            else
            {
                message += "\n" + "Failed";
            }
            client.Send(Serialize(message));
        }
        private bool Search(string query)
        {
            string[] command = query.Split('/');
            string[] buy = command[2].Split(",");
            int movienumber = 0;
            int roomnumber = int.Parse(command[1]) - 1;
            bool result = true;
            try
            {
                for (int i = 0; i < movielist.Count; i++)
                {
                    if (movielist[i].Name.Contains(command[0]))
                    {
                        movienumber = i; break;
                    }
                }

                //tìm số ghế đã mua
                for (int i = 0; i < buy.Length - 1; i++)
                {
                    if (movielist[movienumber].Seats[roomnumber].Contains(buy[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search");
            }
            return result;
        }
        private void ShowDataToInput()
        {
            try
            {
                string result = "";
                for (int i = 0; i < movielist.Count; i++)
                {
                    if (i != 0) result += "\n";
                    result += movielist[i].Name.ToString() + "\n";
                    result += movielist[i].TicketPrice.ToString() + "\n";
                    for (int k = 0; k < movielist[i].RoomNumber.Length; k++)
                    {
                        if (movielist[i].RoomNumber[k] > 0)
                        {
                            result += movielist[i].RoomNumber[k];
                            if (movielist[i].Seats[k] != "") result += ":";
                        }
                        else
                        {
                            continue;
                        }

                        result += movielist[i].Seats[k];
                        if (k < movielist[i].Seats.Length - 1)
                        {
                            result += ";";
                        }
                    }
                    if (i == movielist.Count - 1) continue;
                    result += "\n";
                }
                rtbInput.Text = result;
                data = result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ShowDataToInput");
            }
        }
        private void UpdateData(string message)
        {
            try
            {
                string[] command = message.Split('/');
                string[] buy = command[2].Split(",");
                int roomnumber = int.Parse(command[1]) - 1;
                int movienumber = 0;
                for (int i = 0; i < movielist.Count; i++)
                {
                    if (movielist[i].Name.Contains(command[0]))
                    {
                        movienumber = i; break;
                    }
                }
                if (Search(message))
                {
                    for (int i = 0; i < buy.Length - 1; i++)
                    {
                        if (movielist[movienumber].Seats[roomnumber] != "")
                            movielist[movienumber].Seats[roomnumber] += ",";

                        movielist[movienumber].Seats[roomnumber] += buy[i];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "UpdateData");
            }
        }
        private void ReadJson()
        {
            int[] temp = new int[3] { 1, 2, 3 };
            string[] tempstr = new string[15];
            for (int i = 0; i < tempstr.Length; i++)
            {
                tempstr[i] = "";
            }
            movieDetail = JsonConvert.DeserializeObject<List<MovieDetail>>(data);
            for (int i = 0; i < movieDetail.Count; i++)
            {
                Movie a = new Movie();
                a.Name = movieDetail[i].Title;
                a.TicketPrice = 40000;
                a.RoomNumber = temp;
                a.Seats = tempstr;
                movielist.Add(a);
            }
        }
        /*private int[] AnalyzeRoomData(string room)
        {
            //danh sách từng phòng
            string[] rooms = room.Split(";");
            string[] lastroomsindex = rooms[rooms.Length - 1].Split(':');
            int resultlenght = int.Parse(lastroomsindex[0]);
            int[] result = new int[resultlenght];

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomName = rooms[i].Split(":");
                int temp = int.Parse(roomName[0]) - 1;
                result[temp] = temp + 1;
            }

            return result;
        }
        private string[] AnalyzeRoomSeats(string room)
        {
            //danh sách từng phòng
            string[] rooms = room.Split(";");
            string[] temp = rooms[rooms.Length - 1].Split(":");
            int lastroomnumber = int.Parse(temp[0]);
            string[] result = new string[lastroomnumber];

            for (int i = 0; i < lastroomnumber; i++)
            {
                try
                {
                    string[] roomnumber = rooms[i].Split(":");

                    if ((i + 1) != int.Parse(roomnumber[0]))
                    {
                        for (int j = i; j < (int.Parse(roomnumber[0]) - 1); j++)
                        {
                            result[j] = "";
                            ++i;
                        }
                    }

                    if (roomnumber.Length == 1 && i < result.Length)
                    {
                        result[i] = "";
                        continue;
                    }

                    result[i] = roomnumber[1];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "RoomSeat");
                }
            }

            return result;
        }*/
        private byte[] Serialize(object obj)
        {
            byte[] output = Encoding.UTF8.GetBytes(obj.ToString());
            return output.ToArray();
        }
        private object Deserialize(byte[] bytes)
        {
            string output = Encoding.UTF8.GetString(bytes);
            return output;
        }
        private void ReadFileInput()
        {
            FileStream fileStream;
            try
            {
                fileStream = new FileStream("moviesInput.json", FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có file dữ liệu server", ex.Message);
                return;
            }
            StreamReader rd = new StreamReader(fileStream);
            data = rd.ReadToEnd();
            rd.Close();
            fileStream.Close();
        }
        class Movie
        {
            public string Name { get; set; }
            public double TicketPrice { get; set; }
            public int[] RoomNumber { get; set; }
            public string[] Seats { get; set; }
        }
        private class MovieDetail
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Ex4_Client a = new Ex4_Client();
            clients.Add(a);
            a.Show();
        }

        private void Ex4_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < clientlist.Count; i++)
            {
                clientlist[i].Close();
                clients[i].CloseClient();
            }
        }
    }
}
