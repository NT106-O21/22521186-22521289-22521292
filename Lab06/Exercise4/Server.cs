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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Collections;

namespace Exercise4
{
    public partial class Server : Form
    {
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            ReadFileInput();
            AnalyzeData();
        }
        Socket server, superuser;
        IPEndPoint IP;
        List<Socket> clientlist;
        List<Movie> movielist = new List<Movie>();
        string data;
        double ticketprice = 0;
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
                MessageBox.Show(e.Message,"Listen");
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
            foreach(Socket s in clientlist) 
            {
                Send(s);
            }
            Send(superuser);
        }
        private void SendSocketList()
        {
            superuser.Send(Serialize(clientlist.Count));
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
                    if (message.Contains("superuser"))
                    {
                        superuser = clientlist[clientlist.Count - 1];
                        clientlist.Remove(superuser);
                        rtbLog.Text += date.ToString() + ": Super User Has Connected!" + "\n";
                        SendSocketList();
                        continue;
                    }

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

                    if(Search(message) == true)
                    {
                        UpdateData(message);
                    }
                    ShowDataToInput();
                    if (Search(message) == false)
                    {
                        SendAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Receive");
                return;
            }
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
                for(int i = 0; i < buy.Length - 1; i++)
                {
                    if (movielist[movienumber].Seats[roomnumber].Contains(buy[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch(Exception ex)
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
                        if(k < movielist[i].Seats.Length - 1)
                        {
                            result += ";";
                        }
                    }
                    if (i == movielist.Count - 1) continue;
                    result += "\n";
                }
                rtbInput.Text = result;
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
        private void AnalyzeData()
        {
            int i;
            string room = "";
            string[] datainput = data.Split('\n');
            for (i = 0; (i + 2) < datainput.Length; i += 4)
            {
                if (datainput[i] == "") continue;
                Movie temp = new Movie();
                temp.Name = datainput[i];
                temp.TicketPrice = double.Parse(datainput[i + 1]);
                room = datainput[i + 2];
                temp.RoomNumber = AnalyzeRoomData(room.ToString());
                temp.Seats = AnalyzeRoomSeats(room.ToString());
                movielist.Add(temp);
            }
        }
        private int[] AnalyzeRoomData(string room)
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
            string[] temp = rooms[rooms.Length-1].Split(":");
            int lastroomnumber = int.Parse(temp[0]);
            string[] result = new string[lastroomnumber];

            for (int i = 0; i < lastroomnumber; i++)
            {
                try
                {
                    string[] roomnumber = rooms[i].Split(":");

                    if((i + 1) != int.Parse(roomnumber[0]))
                    {
                        for(int j = i; j < (int.Parse(roomnumber[0]) - 1); j++)
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
        }
        private void ReadFileInput()
        {
            FileStream fileStream;
            try
            {
                fileStream = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có file dữ liệu server", ex.Message);
                return;
            }
            StreamReader rd = new StreamReader(fileStream);
            rtbInput.Text = rd.ReadToEnd();
            data = rtbInput.Text;
            rd.Close();
            fileStream.Close();
        }
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
        private void btnStartListen_Click(object sender, EventArgs e)
        {
            Listen();
        }
        class Movie
        {
            public string Name { get; set; }
            public double TicketPrice { get; set; }
            public int[] RoomNumber { get; set; }
            public string[] Seats { get; set; }
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
