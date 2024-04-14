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

namespace Exercise4
{
    public partial class Server : Form
    {
        List<Socket> clientlist;
        List<Movie> movielist;
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            ReadFileInput();
            AnalyzeData();
        }

        Socket server;
        IPEndPoint IP;
        string data;
        private void Listen()
        {
            Socket server;
            Socket client;
            clientlist = new List<Socket>();
            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024);
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(ipserver);

                while (!server.Connected)
                {
                    server.Listen();
                    client = server.Accept();

                    clientlist.Add(client);

                    Send(client);
                    Receive(client);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        /*private void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 1024);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến client", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(() => Send(server));
            listen.Start();
        }*/
        private void Close(Socket socket)
        {
            socket.Close();
        }
        private void Send(Socket client)
        {
            client.Send(Serialize(rtbInput.Text));
        }
        private void Receive(Socket client)
        {
            try
            {
                while (true)
                {
                    byte[] receive = new byte[1024 * 5000];
                    client.Receive(receive);

                    string message = (string)Deserialize(receive);
                    rtbLog.Text += message + "\n";
                    AnalyzeData();
                    Search(message);
                }
            }
            catch
            {
                Close();
            }
        }
        private void Search(string query)
        {
            string[] command = query.Split('/');
            int movienumber = 0;
            for (int i = 0; i < movielist.Count; i++)
            {
                if (movielist[i].Name.Contains(command[0]))
                {
                    movienumber = i; break;
                }
            }
            for(int i = 0; i < movielist[movienumber].RoomNumber.Length; i++)
            {

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
            int[] result = new int[rooms.Length];
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomName = rooms[i].Split(":");
                if (roomName[0] == "" || roomName[0] == "\n") continue;
                result[i] = int.Parse(roomName[0]);
            }
            return result;
        }
        private string[] AnalyzeRoomSeats(string room)
        {
            string[] result = new string[1];

            //danh sách từng phòng
            string[] rooms = room.Split(";");

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomName = rooms[i].Split(":");
                if (roomName[1] == "" || roomName[1] == "\n") continue;

                string[] seats = roomName[1].Split(",");
                for(int j = 0; j < seats.Length; j++)
                {
                    result[j] = seats[j];
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
            data = rd.ReadToEnd();
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
            return output.ToString();
        }
        private void btnStartListen_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Listen));
            thread.Start();
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            
        }
        class Movie
        {
            public string Name { get; set; }
            public double TicketPrice { get; set; }
            public int[] RoomNumber { get; set; }
            public string[] Seats { get; set; }
        }
    }
}
