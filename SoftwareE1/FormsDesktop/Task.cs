using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Media;


namespace SoftwareE1.FormsDesktop
{
    public partial class Task : Form
    {
        private SoundPlayer soundPlayer;
        DBHandler dbHandler = new DBHandler();
        public Task()
        {
            InitializeComponent();
            loadTask();
        }

        public void loadTask()
        {

            dbHandler.GetTaskData(taskDataGridView);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddForm Addform = new AddForm(this);
            Addform.FormClosed += AddForm_FormClosed;
            Addform.ShowDialog();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Updating
            loadTask();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (taskDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = taskDataGridView.SelectedRows[0];

                //Getting ID
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                taskDataGridView.Rows.Remove(selectedRow);
                dbHandler.DeleteTask(id);
            }
        }

        private void taskDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Done Button
            if (taskDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = taskDataGridView.Rows[e.RowIndex];
                String taskDifficulty = (string)row.Cells[2].Value;
                int rewards = 0;

                switch (taskDifficulty)
                {
                    case "Easy":
                        rewards = rewards + 25;
                        break;
                    case "Medium":
                        rewards = rewards + 50;
                        break;
                    case "Hard":
                        rewards = rewards + 75;
                        break;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to Finish this task and get {rewards} coins?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    row = taskDataGridView.Rows[e.RowIndex];
                    int taskID = (int)row.Cells[0].Value;

                    //Updating user currency after completing task
                    int x = dbHandler.getUserCurrency();
                    Data.currentSessionUser_Coins = x;

                    rewards = rewards + x;

                    Data.currentSessionUser_Coins = rewards;
                    dbHandler.updateUserCurrency(rewards);

                    //Play Sound
                    soundPlayer = new SoundPlayer(Properties.Resources.coin);
                    soundPlayer.Play();

                    //Deleteing finished Task after confirmation
                    dbHandler.DeleteTask(taskID);
                    loadTask();
                }
            }
        }
    }
}
