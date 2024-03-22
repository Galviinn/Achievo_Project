using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace SoftwareE1
{
    internal class DBHandler
    {
        string connectionString = "Server=localhost;Database=achievo;Uid=root;Pwd=;";
        string currentUser = Data.currentSessionUser;
        int currentUserCoins = Data.currentSessionUser_Coins;

        //Registration Page
        public bool InsertRegistrationData(string username, string password, string email)
        {
            bool isRegistrationSuccessful = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO user (uname, pass, email) VALUES (@uname, @pass, @email)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@uname", username);
                        command.Parameters.AddWithValue("@pass", password);
                        command.Parameters.AddWithValue("@email", email);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            isRegistrationSuccessful = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return isRegistrationSuccessful;
        }

        public void createUserData(string username)
        {
            string query = "";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //Preparing user account in database table

                connection.Open();

                //table.store
                query = "INSERT INTO store (uname) VALUES (@uname)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uname", username);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        //End of Registration

        //Login Page
        public bool ValidateLogin(string username, string password)
        {
            bool isValidLogin = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT COUNT(*) FROM user WHERE uname = @uname AND pass = @pass";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uname", username);
                        command.Parameters.AddWithValue("@pass", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            isValidLogin = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return isValidLogin;
        }
        //End of Login

        //Task Feature
        public bool InsertTask(string textBox, string comboBox)
        {
            bool insertTask = false;

            string query = "";

            

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();
                    query = "INSERT INTO task (uname, taskName, taskDifficulty) VALUES (@uname, @taskName, @taskDifficulty)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uname", currentUser);
                        command.Parameters.AddWithValue("@taskName", textBox);
                        command.Parameters.AddWithValue("@taskDifficulty", comboBox);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }

            catch
            {
                insertTask = true;
            }

            return insertTask;
        }

        public bool DeleteTask(int taskID)
        {
            bool deleteTask = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    
                    string query = $"DELETE FROM task WHERE taskID = (@taskID)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@taskID", taskID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    return deleteTask;
                    connection.Close();
                }
            }
            catch(Exception e)
            {
                //catch
                deleteTask = true;
                return deleteTask;
            }
            
        }

        public DataTable taskLoad()
        {
            DataTable dataTable = new DataTable();
            

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT taskID AS ID, taskName AS Description, taskDifficulty AS Difficulty FROM task WHERE uname = @uname";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@uname", currentUser);

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }catch { }

                connection.Close();

            }

            return dataTable;
        }

        //Task 1.1: Load Data Handler
        public void GetTaskData(DataGridView dataGridView)
        {

            DataTable dataTable = taskLoad();


            dataGridView.Rows.Clear();


            foreach (DataRow row in dataTable.Rows)
            {

                int id = Convert.ToInt32(row["ID"]);
                string description = row["Description"].ToString();
                string difficulty = row["Difficulty"].ToString();


                dataGridView.Rows.Add(id, description, difficulty);
            }
        }
        //End of Task

        //User Currency System
        public void updateUserCurrency(int coins)
        { 
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE user SET userCoin = @coins WHERE uname = @uname";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@coins", coins);
                    command.Parameters.AddWithValue("@uname", currentUser);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public int getUserCurrency()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT userCoin FROM user WHERE uname = @uname";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uname", currentUser);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    int coins = Convert.ToInt32(result);

                    return coins;
                }
                connection.Close();
            }
        }
        //End of User Currency System

        //Notes Feature
        public void newNote(string noteTitle, string notePath)
        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO notes (uname, notesTitle, notesPath) VALUES (@uname, @title, @path)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@uname", currentUser);
                        command.Parameters.AddWithValue("@title", noteTitle);
                        command.Parameters.AddWithValue("@path", notePath);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateNote(string noteTitle, int noteID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE notes SET notesTitle = @title WHERE notesID = @ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", noteTitle);
                    command.Parameters.AddWithValue("@uname", currentUser);
                    command.Parameters.AddWithValue("@ID", noteID);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public (string, string) readNote(int ID)
        {
            string noteTitle = "";
            string notePath = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT notesTitle FROM notes WHERE notesID = @ID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            noteTitle = result.ToString();
                        }

                    }

                    query = "SELECT notesPath FROM notes WHERE notesID = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            notePath = result.ToString();
                        }

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return (noteTitle, notePath);
        }

        public void DeleteNote(int ID)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                string query = $"DELETE FROM notes WHERE notesID = @notesID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@notesID", ID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }

        public DataTable noteLoad()
        {
            DataTable dataTable = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT notesID AS ID, notesTitle AS Title, notesPath AS Path FROM notes WHERE uname = @uname";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@uname", currentUser);

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch { }

                connection.Close();

            }

            return dataTable;
        }

        //Notes 1.1: Load Data Handler
        public void GetNoteData(DataGridView dataGridView)
        {
            DataTable dataTable = noteLoad();

            dataGridView.Rows.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                // Membaca kolom dari setiap baris
                int noteID = Convert.ToInt32(row["ID"]);
                string noteTitle = row["Title"].ToString();
                string notePath = row["Path"].ToString();

                // Menambahkan data ke DataGridView
                dataGridView.Rows.Add(noteID, noteTitle, notePath);
            }
        }
        //End of Notes

        //Calendar Feature
        public bool NewEvent(string calendarDate, string calendarEvent)
        {
            bool x = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"INSERT INTO calendar (uname, calendarDate, calendarEvent) VALUES (@uname, @date, @event)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uname", currentUser);
                        command.Parameters.AddWithValue("@date", calendarDate);
                        command.Parameters.AddWithValue("@event", calendarEvent);

                        connection.Open();
                        command.ExecuteNonQuery();

                        x = true;
                        return x;

                        command.Dispose();
                        connection.Close();
                    }
                }
            }
            catch
            {
                return x;
            }
        }

        public string LoadEvents(string day, int month, int year)
        {
            string result = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM calendar WHERE calendarDate = @Date AND uname = @uname";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@uname", currentUser);
                    command.Parameters.AddWithValue("@Date", day + "/" + month + "/" + year);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        result = reader["calendarEvent"].ToString();
                    }

                    reader.Dispose();
                    command.Dispose();
                    connection.Close();

                    return result;
                }
            }
        }

        public bool UpdateEvent(string calendarDate, string calendarEvent)
        {
            bool x = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = $"UPDATE calendar SET calendarEvent = @event WHERE uname = @uname AND calendarDate = @date";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uname", currentUser);
                        command.Parameters.AddWithValue("@date", calendarDate);
                        command.Parameters.AddWithValue("@event", calendarEvent);

                        connection.Open();
                        command.ExecuteNonQuery();

                        x = true;
                        return x;

                        command.Dispose();
                        connection.Close();
                    }
                }
            }
            catch
            {
                return x;
            }
        }

        public bool DeleteEvent(string calendarDate)
        {
            bool x = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = $"DELETE FROM calendar WHERE calendarDate = @date AND uname = @uname";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uname", currentUser);
                        command.Parameters.AddWithValue("@date", calendarDate);

                        connection.Open();
                        command.ExecuteNonQuery();

                        x = true;
                        return x;

                        command.Dispose();
                        connection.Close();
                    }
                }
            }
            catch
            {
                return x;
            }
        }
        //End of Calendar

        //Store Feature
        public string GetChievy()
        {
            string imageName = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT currentChievy FROM store WHERE uname = @uname";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@uname", currentUser);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imageName = reader.GetString(0);
                        }
                    }
                }
                connection.Close();
            }
            return imageName;
        }

        public void SetStartChievy(string chievy, string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE store SET currentChievy = @chievy WHERE uname = @uname";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@chievy", chievy);
                    command.Parameters.AddWithValue("@uname", user);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetChievy(string chievy)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE store SET currentChievy = @chievy WHERE uname = @uname";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@chievy", chievy);
                    command.Parameters.AddWithValue("@uname", currentUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public string GetUnlockedChievy()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT storeUnlocked FROM store WHERE uname = @uname";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uname", currentUser);

                    // Execute the query and retrieve the result
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
                connection.Close();
            }

            return string.Empty;
        }

        public void UnlockChievy(string chievy)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                string existingSkins = GetUnlockedChievy();

                string unclockedChievy = existingSkins + "," + chievy; 

                connection.Open();
                string updateQuery = "UPDATE store SET storeUnlocked = @chievy WHERE uname = @uname";
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@chievy", unclockedChievy);
                    command.Parameters.AddWithValue("@uname", currentUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool UnlockChievyWithCoins(int coins)
        {
            if(currentUserCoins < coins)
            {
                return false;

            }
            else
            {
                currentUserCoins = getUserCurrency();
                currentUserCoins = currentUserCoins - coins;
                updateUserCurrency(currentUserCoins);
                return true;
            }
        }
        //End of Store

        //ACHIEVO READY!
    }
}



