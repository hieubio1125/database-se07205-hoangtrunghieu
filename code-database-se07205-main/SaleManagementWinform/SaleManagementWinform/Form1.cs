using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SaleManagementWinform
{
    public partial class Form1 : Form
    {
        private object Utilscs;

        public Form1()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            // Update new code gituhub 
            // Test commit github

            string username = txb_username.Text;
            string password = txb_password.Text;

            string hashPassword = Utils.HashPassword(password);

            bool checkLogin = CheckLogin(username, hashPassword);

            if (checkLogin)
            {

                MenuForm main = new MenuForm();
                main.Show();
                this.Hide();

            }
            else
            {


                MessageBox.Show("Username or password is incorrect !");
            }
            
        }
        private bool CheckLogin(string Username, string hashedPassword)
        {
            string query = "SELECT password From Employee WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", Username);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password"].ToString(); // Retrieved hashed password
                            int roleId = Convert.ToInt32(reader["roleId"]); // Retrieved roleId


                            Utilscs = roleId; // Assign the roleId to your global variable or utility class

                            return storedHash == hashedPassword; // Compare the hashes
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return false;// Return false if username not found or any error occurs
        }
        public static class Connection
        {
            public static string SQLConnection = "Server=HIU-CHUNN;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        }
        public static class Utils
        {
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        builder.Append(b.ToString("x2")); // Convert to hexadecimal
                    }
                    return builder.ToString();
                }
            }
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
