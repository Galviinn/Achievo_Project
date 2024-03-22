using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace SoftwareE1
{
    public partial class Get_Started : Form
    {
        string genderChosen = "";
        public Get_Started()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) ||
                string.IsNullOrEmpty(Password.Text) ||
                string.IsNullOrEmpty(Eaddress.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Stop further execution
            }
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return; // Stop further execution
            }

            else
            {
                DBHandler dbHandler = new DBHandler();
                string user = Username.Text;
                bool registrationResult = dbHandler.InsertRegistrationData(Username.Text, Password.Text, Eaddress.Text);

                if (registrationResult)
                {
                    // Registration successful, navigate to the login page
                    dbHandler.createUserData(Username.Text);

                    if (genderChosen == "Male")
                    {
                        string chievy = "chievyBGMale";
                        dbHandler.SetStartChievy(chievy, user);
                    }
                    if (genderChosen == "Female")
                    {
                        string chievy = "chievyBGFemale";
                        dbHandler.SetStartChievy(chievy, user);
                    }

                    Login_page login = new Login_page();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    // Registration failed, display an error message or take appropriate action
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            Login_page login = new Login_page();
            login.Show();
            this.Hide();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            genderChosen = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            genderChosen = "Female";
        }
    }
}
