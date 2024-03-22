using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareE1
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Get_Started get_started = new Get_Started();
            get_started.Show();

            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            DBHandler dbHandler = new DBHandler();
            bool isValidLogin = dbHandler.ValidateLogin(username, password);

            if (isValidLogin)
            {
                // Login successful, navigate to the main application or desired page
                Main_Menu mainForm = new Main_Menu();
                Data.currentSessionUser = username;
                int coins = dbHandler.getUserCurrency();
                Data.currentSessionUser_Coins = coins;

                mainForm.Show();
                this.Hide();


            }
            else
            {
                // Invalid login credentials, display an error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }
    }
}
