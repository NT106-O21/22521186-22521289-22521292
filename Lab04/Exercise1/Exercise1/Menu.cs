namespace Exercise1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Lab04.Ex1 ex1 = new Lab04.Ex1();
            ex1.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Lab04.Ex2 ex2 = new Lab04.Ex2();
            ex2.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Lab04.Ex3 ex3 = new Lab04.Ex3();
            ex3.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Lab04.Ex4 ex4 = new Lab04.Ex4();
            ex4.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            Lab04.Ex5 ex5 = new Lab04.Ex5();
            ex5.Show();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            Lab04.Ex6 ex6 = new Lab04.Ex6();
            ex6.Show();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            Lab04.Ex7 ex7 = new Lab04.Ex7();
            ex7.Show();
        }
    }
}
