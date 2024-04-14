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
    public partial class Receiption1 : Form
    {
        public Receiption1()
        {
            InitializeComponent();
            Connect();
        }
        string data;
        Socket socket;
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024);
        List<Movie> movielist = new List<Movie>();
        private void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(iPEndPoint);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        private void Close()
        {
            socket.Close();
        }
        private void Send()
        {
            string send = ReadBuyInfo();
            if (send != null)
            {
                socket.Send(Serialize(send));
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
                    data = message;
                    AnalyzeData();
                    ShowReplyFromServer(message);
                    /*MessageBox.Show(message);*/
                }
            }
            catch
            {
                Close();
            }
        }
        private void ShowReplyFromServer(string message)
        {
            if (message.Contains("Successfully Purchased"))
            {
                MessageBox.Show(message, "Success");
            }
            if (message.Contains("Failed"))
            {
                MessageBox.Show(message, "Failed");
            }
            ShowData();
        }
        private void ShowData()
        {
            ShowMovieName();
        }
        private void ShowMovieName()
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
        private void ShowRoom(string moviename)
        {
            cbbRoom.Items.Clear();
            foreach (Movie movie in movielist)
            {
                if (movie.Name == moviename)
                {
                    for (int i = 0; i < movie.RoomNumber.Length; i++)
                    {
                        cbbRoom.Items.Add(movie.RoomNumber[i]);
                    }
                }
            }
        }
        private void AnalyzeData()
        {
            int i;
            string room = "";
            string[] datainput = data.Split('\n');
            for (i = 0; (i + 2) < datainput.Length; i+=4)
            {
                if (datainput[i] == "") continue;
                Movie temp = new Movie();
                temp.Name = datainput[i];
                temp.TicketPrice = double.Parse(datainput[i + 1]);
                room = datainput[i + 2];
                temp.RoomNumber = AnalyzeRoomData(room.ToString());
                movielist.Add(temp);
            }
        }
        private int[] AnalyzeRoomData(string room)
        {
            string[] rooms = room.Split(";");
            int[] result = new int[rooms.Length];
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == "" || rooms[i] == "\n") continue;
                result[i] = int.Parse(rooms[i]);
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
            /*Receive();*/
        }
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
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
                        txtCheckedBox.Text += chkBox.Text + "; ";
                    }
                }
            }
        }
        class Movie
        {
            public string Name { get; set; }
            public double TicketPrice { get; set; }
            public int[] RoomNumber { get; set; }
            public string Seats { get; set; }
        }

        private void cbbFilmName_TextChanged(object sender, EventArgs e)
        {
            ShowRoom(cbbFilmName.Text);
        }
    }
}
