using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftwareE1.FormsDesktop
{
    public partial class Store : Form
    {
        DBHandler dbHandler = new DBHandler();
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            List<Button> skinButtons = new List<Button>();
            skinButtons.Add(selectPic2);
            skinButtons.Add(selectPic3);
            skinButtons.Add(selectPic5);
            skinButtons.Add(selectPic6);

            string unlockedSkinsString = dbHandler.GetUnlockedChievy();

            // Split the unlocked skins into an array
            string[] unlockedSkins = unlockedSkinsString.Split(',');

            // Iterate through each skin button
            foreach (Button skinButton in skinButtons)
            {
                // Get the skin name from the button's tag property
                string skinName = skinButton.Tag.ToString();

                // Check if the skin is unlocked
                if (unlockedSkins.Contains(skinName))
                {
                    // Skin is unlocked
                    skinButton.Text = "Select";
                    skinButton.Enabled = true;
                }
                else
                {
                    // Skin is locked
                    skinButton.Text = "Unlock";
                    skinButton.Enabled = true;
                }
            }
        }

        private void selectPic1_Click(object sender, EventArgs e)
        {
            string chievy = "chievyBGMale";
            dbHandler.SetChievy(chievy);
            MessageBox.Show("Chievy skin selected!", "Success!", MessageBoxButtons.OK);
        }

        private void selectPic4_Click(object sender, EventArgs e)
        {
            string chievy = "chievyBGFemale";
            dbHandler.SetChievy(chievy);
        }

        //Old Money Skin
        private void selectPic2_Click(object sender, EventArgs e)
        {
            Button skinButton = (Button)sender;
            string skinName = skinButton.Tag.ToString();

            if (skinButton.Text == "Unlock")
            {
                // Update the player's unlocked skins in the database
                DialogResult result = MessageBox.Show("Unlock this skin for 100 coins?", "Unlock Skin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool permission = dbHandler.UnlockChievyWithCoins(100);

                    if (permission)
                    {
                        string unlockedSkinsString = skinName;
                        dbHandler.UnlockChievy(unlockedSkinsString);

                        // Update the button state
                        skinButton.Text = "Select";
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Coins!", "Sorry!", MessageBoxButtons.OK);
                    }

                }
            }
            else if (skinButton.Text == "Select")
            {
                // Perform the action for selecting the skin
                dbHandler.SetChievy(skinName);
                MessageBox.Show("Chievy skin selected!", "Success!", MessageBoxButtons.OK);
            }
        }

        //Dark Man Skin
        private void selectPic3_Click(object sender, EventArgs e)
        {
            Button skinButton = (Button)sender;
            string skinName = skinButton.Tag.ToString();

            if (skinButton.Text == "Unlock")
            {
                // Update the player's unlocked skins in the database
                DialogResult result = MessageBox.Show("Unlock this skin for 1000 coins?", "Unlock Skin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool permission = dbHandler.UnlockChievyWithCoins(1000);

                    if (permission)
                    {
                        string unlockedSkinsString = skinName;
                        dbHandler.UnlockChievy(unlockedSkinsString);

                        // Update the button state
                        skinButton.Text = "Select";
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Coins!", "Sorry!", MessageBoxButtons.OK);
                    }

                }
            }
            else if (skinButton.Text == "Select")
            {
                // Perform the action for selecting the skin
                dbHandler.SetChievy(skinName);
                MessageBox.Show("Chievy skin selected!", "Success!", MessageBoxButtons.OK);
            }
        }

        //Female Alter Skin
        private void selectPic5_Click(object sender, EventArgs e)
        {
            Button skinButton = (Button)sender;
            string skinName = skinButton.Tag.ToString();

            if (skinButton.Text == "Unlock")
            {
                // Update the player's unlocked skins in the database
                DialogResult result = MessageBox.Show("Unlock this skin for 100 coins?", "Unlock Skin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool permission = dbHandler.UnlockChievyWithCoins(100);

                    if (permission)
                    {
                        string unlockedSkinsString = skinName;
                        dbHandler.UnlockChievy(unlockedSkinsString);

                        // Update the button state
                        skinButton.Text = "Select";
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Coins!", "Sorry!", MessageBoxButtons.OK);
                    }

                }
            }
            else if (skinButton.Text == "Select")
            {
                // Perform the action for selecting the skin
                dbHandler.SetChievy(skinName);
                MessageBox.Show("Chievy skin selected!", "Success!", MessageBoxButtons.OK);
            }
        }

        //Wonder Chievy Skin
        private void selectPic6_Click(object sender, EventArgs e)
        {
            Button skinButton = (Button)sender;
            string skinName = skinButton.Tag.ToString();

            if (skinButton.Text == "Unlock")
            {
                // Update the player's unlocked skins in the database
                DialogResult result = MessageBox.Show("Unlock this skin for 1000 coins?", "Unlock Skin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool permission = dbHandler.UnlockChievyWithCoins(1000);

                    if (permission)
                    {
                        string unlockedSkinsString = skinName;
                        dbHandler.UnlockChievy(unlockedSkinsString);

                        // Update the button state
                        skinButton.Text = "Select";
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Coins!", "Sorry!", MessageBoxButtons.OK);
                    }

                }
            }
            else if (skinButton.Text == "Select")
            {
                // Perform the action for selecting the skin
                dbHandler.SetChievy(skinName);
                MessageBox.Show("Chievy skin selected!", "Success!", MessageBoxButtons.OK);
            }
        }
    }
}
