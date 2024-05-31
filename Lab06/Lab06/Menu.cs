namespace Lab06
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Lab06.Ex1 ex1 = new Lab06.Ex1();
            ex1.ShowDialog();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Lab06.Ex2 ex2 = new Lab06.Ex2();
            ex2.ShowDialog();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Lab06.Ex3 ex3 = new Lab06.Ex3();
            ex3.ShowDialog();
        }
    }
}
