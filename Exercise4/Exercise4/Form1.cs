namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private delegate void SafeCallDelegate(string text);
        private void btnReceiption1_Click(object sender, EventArgs e)
        {
            Receiption1 receiption1 = new Receiption1();
            receiption1.Show();
        }

        private void btnReceiption2_Click(object sender, EventArgs e)
        {
            Receiption2 receiption2 = new Receiption2();
            receiption2.Show();
        }

        private void btnReceiption3_Click(object sender, EventArgs e)
        {
            Receiption3 receiption3 = new Receiption3();
            receiption3.Show();
        }
        private void btnServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
