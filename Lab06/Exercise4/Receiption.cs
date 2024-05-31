using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Receiption : Form
    {
        public Receiption()
        {
            InitializeComponent();
            Connect();
        }
        string data;
        Socket socket;
        double ticketprice = 0;
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024);
        List<Movie> movielist = new List<Movie>();
        private void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(iPEndPoint);
            }
            catch (Exception e)
            {
                /*MessageBox.Show("Không thể kết nối đến server", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                MessageBox.Show(e.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread receive = new Thread(Receive);
            receive.IsBackground = true;
            receive.Start();
        }
        private void Close()
        {
            socket.Close();
        }
        private void Send()
        {
            string send = ReadBuyInfo();
            try
            {
                if (send != null)
                {
                    socket.Send(Serialize(send));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Send");
            }
        }
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] receive = new byte[1024 * 5000];
                    socket.Receive(receive);

                    string message = (string)Deserialize(receive);
                    message = message.Trim('\0');

                    data = message;
                    AnalyzeData();

                    ShowReplyFromServer();
                }
            }
            catch (Exception e)
            {
                /*Close();*/
                MessageBox.Show(e.Message, "Receive");
            }
        }
        private void ShowReplyFromServer()
        {
            try
            {
                if (data.Contains("Successfully Purchased"))
                {
                    string message = "Successfully Purchased\n";

                    data.Replace("Successfully Purchased", "");

                    foreach (Control c in this.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ck = (CheckBox)c;
                            ck.CheckState = 0;
                        }
                    }

                    MessageBox.Show(message, "Success");
                    ShowSeats(cbbFilmName.Text, cbbRoom.Text);
                }
                if (data.Contains("Failed"))
                {
                    MessageBox.Show("Failed");
                    data.Replace("Failed", "");
                }
                ShowData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ShowReply");
            }
        }
        private void ShowData()
        {
            AddMovieName();
            ShowSeats(cbbFilmName.Text, cbbRoom.Text);
        }
        private void ShowSeats(string filmname, string room)
        {
            try
            {
                if (filmname == "" || room == "") return;
                int roomnumber = int.Parse(room) - 1;
                int movienumber = 0;

                foreach (Control c in this.Controls)
                {
                    c.Visible = true;
                    if(c is CheckBox)
                    {
                        CheckBox ck = (CheckBox)c;
                        ck.CheckState = 0;
                    }
                }

                for (int i = 0; i < movielist.Count; i++)
                {
                    if (filmname == movielist[i].Name)
                    {
                        movienumber = i;
                        break;
                    }
                }

                string[] seats = movielist[movienumber].Seats[roomnumber].Split(',');
                foreach (string seat in seats)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.Name == seat && c is CheckBox && seat != "")
                        {
                            c.Visible = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShowSeats");
            }
        }
        private void AddMovieName()
        {
            cbbFilmName.Items.Clear();
            foreach (Movie movie in movielist)
            {
                if (movie != null)
                {
                    cbbFilmName.Items.Add(movie.Name);
                }
            }
        }
        private void AddRoom(string moviename)
        {
            cbbRoom.Items.Clear();
            foreach (Movie movie in movielist)
            {
                if (movie.Name == moviename)
                {
                    for (int i = 0; i < movie.RoomNumber.Length; i++)
                    {
                        if (movie.RoomNumber[i] == 0) continue;
                        cbbRoom.Items.Add(movie.RoomNumber[i]);
                    }
                }
            }
        }
        private void AnalyzeData()
        {
            try
            {
                if (data == "") return;
                string[] datainput = data.Split('\n');
                if (movielist.Count() == 0)
                {
                    AddMovieList(datainput);
                }
                else
                {
                    UpdateMovieList(datainput);
                }
                txtCheckedBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source, "AnalyzeData");
            }
        }
        private void UpdateMovieList(string[] datainput)
        {
            string room = "";
            int j = 0;
            for (int i = 0; (i + 2) < datainput.Length; i += 4)
            {
                try
                {
                    if (datainput[i] == "") continue;
                    if (datainput[i] == "Successfully Purchased" || datainput[i] == "Failed") continue;
                    Movie temp = new Movie();
                    temp.Name = datainput[i];
                    temp.TicketPrice = double.Parse(datainput[i + 1]);
                    room = datainput[i + 2];
                    temp.RoomNumber = AnalyzeRoomData(room.ToString());
                    temp.Seats = AnalyzeRoomSeats(room.ToString());
                    movielist[j] = temp;
                    j++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Analyze Data");
                }
            }
            ShowData();
        }
        private void AddMovieList(string[] datainput)
        {
            string room = "";
            for (int i = 0; (i + 2) < datainput.Length; i += 4)
            {
                try
                {
                    if (datainput[i] == "") continue;
                    if (datainput[i] == "Successfully Purchased" || datainput[i] == "Failed") continue;
                    Movie temp = new Movie();
                    temp.Name = datainput[i];
                    temp.TicketPrice = double.Parse(datainput[i + 1]);
                    room = datainput[i + 2];
                    temp.RoomNumber = AnalyzeRoomData(room.ToString());
                    temp.Seats = AnalyzeRoomSeats(room.ToString());
                    movielist.Add(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Analyze Data");
                }
            }
        }
        private int[] AnalyzeRoomData(string room)
        {
            /*//danh sách từng phòng
            string[] rooms = room.Split(";");
            int[] result = new int[rooms.Length];
            for (int i = 0; i < rooms.Length; i++)
            {
                try
                {
                    string[] roomName = rooms[i].Split(":");
                    if (roomName[0] == "" || roomName[0] == "\n" || roomName[0] == " ") continue;
                    if (roomName[0] == " ") result[i] = 0;
                    result[i] = int.Parse(roomName[0]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "RoomData");
                }
            }
            return result;*/

            string[] rooms = room.Split(";");
            string[] lastroomsindex = rooms[rooms.Length - 1].Split(':');
            if (lastroomsindex[0] == "") lastroomsindex = rooms[rooms.Length - 2].Split(':');
            int resultlenght = int.Parse(lastroomsindex[0]);
            int[] result = new int[resultlenght];

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomName = rooms[i].Split(":");
                if (roomName[0] == "") continue;
                int temp = int.Parse(roomName[0]) - 1;
                result[temp] = temp + 1;
            }

            return result;
        }
        private string[] AnalyzeRoomSeats(string room)
        {
            //danh sách từng phòng
            room = room.Trim();
            string[] rooms = room.Split(";");
            string[] temp;
            if (rooms[rooms.Length - 1] == "") temp = rooms[rooms.Length - 2].Split(":");
            else
            {
                temp = rooms[rooms.Length - 1].Split(":");
            }
            int lastroomnumber = int.Parse(temp[0]);
            string[] result = new string[lastroomnumber];

            for (int i = 0; i < lastroomnumber; i++)
            {
                try
                {
                    string[] roomnumber = rooms[i].Split(":");

                    if ((i + 1) != int.Parse(roomnumber[0]))
                    {
                        for (int j = i; j < int.Parse(roomnumber[0]) - 1; j++)
                        {
                            result[j] = "";
                            i++;
                        }
                    }

                    if (roomnumber.Length == 1)
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
        private string ReadBuyInfo()
        {
            string output = cbbFilmName.Text + "/" + cbbRoom.Text + "/" + txtCheckedBox.Text;
            return output;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Send();
        }
        private void Rct_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 97);
                checkBox.Name = "A" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "A" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 125);
                checkBox.Name = "B" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "B" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 150);
                checkBox.Name = "C" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "C" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckedBox.Text = "";
            CheckBox chkBox = new CheckBox();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    chkBox = (CheckBox)c;
                    if (chkBox.Checked == true)
                    {
                        txtCheckedBox.Text += chkBox.Text + ",";
                    }
                }
            }

            //tinh tien
            double result = 0;
            int movienumber = 0;
            string lowSeats = "A1,A5,C1,C5,B1,B5";
            string normalSeats = "A2,A3,A4,C2,C3,C4";
            string vipSeats = "B2,B3,B4";

            string[] seatsbuy = txtCheckedBox.Text.Split(',');

            for (int i = 0; i < movielist.Count; i++)
            {
                if (cbbFilmName.Text == movielist[i].Name)
                {
                    movienumber = i;
                    break;
                }
            }

            foreach (string seat in seatsbuy)
            {
                if (seat == "") continue;
                if (lowSeats.Contains(seat))
                {
                    result += (movielist[movienumber].TicketPrice / 4);
                    continue;
                }
                if (normalSeats.Contains(seat))
                {
                    result += (movielist[movienumber].TicketPrice * 1);
                    continue;
                }
                if (vipSeats.Contains(seat))
                {
                    result += (movielist[movienumber].TicketPrice * 2);
                    continue;
                }
            }
            txtPrice.Text = result.ToString() + "đ";
        }
        class Movie
        {
            public string Name { get; set; }
            public double TicketPrice { get; set; }
            public int[] RoomNumber { get; set; }
            public string[] Seats { get; set; }
        }

        private void cbbFilmName_TextChanged(object sender, EventArgs e)
        {
            cbbRoom.Text = "";
            AddRoom(cbbFilmName.Text);
        }

        private void Receiption1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void cbbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbFilmName.Text == "") return;
            ShowSeats(cbbFilmName.Text, cbbRoom.Text);
        }
        public void btnBuy_SetLock()
        {
            this.btnBuy.Visible = false;
        }
        public void btnBuy_SetUnlock()
        {
            this.btnBuy.Visible = true;
        }
    }
}
