namespace SoftwareE1
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login_page login_page = new Login_page();
            login_page.Show();

            this.Hide();
        }

        private void GetStarted_Click(object sender, EventArgs e)
        {
            Get_Started get_started = new Get_Started();
            get_started.Show();

            this.Hide();
        }
    }
}