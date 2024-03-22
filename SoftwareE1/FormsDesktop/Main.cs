using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareE1.FormsDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();

            string chievy = dbHandler.GetChievy();
            mainBackground.Image = Properties.Resources.ResourceManager.GetObject(chievy) as Image;

            int x = dbHandler.getUserCurrency();
            Data.currentSessionUser_Coins = x;
            string coins = Convert.ToString(x);
            userCoins.Text = $"{coins}";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Exit
                Application.Exit();
            }
        }
    }
}
