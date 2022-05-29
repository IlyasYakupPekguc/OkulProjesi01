namespace OkulProjesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            textUserName.Clear();   
            textPassword.Clear();   
            textUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "Admin" && textPassword.Text == "1234")
            {
                new Anasayfa().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yor username or password is incorrect, try again.");
                textUserName.Clear();   
                textPassword.Clear();
                textUserName.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}