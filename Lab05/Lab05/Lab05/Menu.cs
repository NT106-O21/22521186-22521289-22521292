namespace Lab05
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Ex1_LoginForm ex1_LoginForm = new Ex1_LoginForm();
            ex1_LoginForm.ShowDialog();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Lab05.Ex2 ex2 = new Lab05.Ex2();
            ex2.ShowDialog();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Lab05.Ex3 ex3 = new Lab05.Ex3();
            ex3.ShowDialog();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Lab05.Ex4 ex4 = new Lab05.Ex4();
            ex4.ShowDialog();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            Lab05.Ex5 ex5 = new Lab05.Ex5();
            ex5.ShowDialog();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            Lab05.Ex6 ex6 = new Lab05.Ex6();
            ex6.ShowDialog();
        }
    }



}
