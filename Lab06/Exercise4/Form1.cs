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
            Receiption receiption1 = new Receiption();
            receiption1.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
