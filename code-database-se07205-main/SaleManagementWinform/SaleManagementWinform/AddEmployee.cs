using Microsoft.VisualBasic.CompilerServices;
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

namespace SaleManagementWinform
{
    public partial class AddEmployee: Form
    {

        public static string SQLConnection
          = "Server=HIU-CHUNN;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public AddEmployee()
        {
            InitializeComponent();
        }

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
        public static void InsertData(string id, string name, int role, string email, string hashedPassword)
        {
            // Implementation here
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string fullname = txb_name.Text;
            string code = txb_code.Text;
            string username = txb_username.Text;
            string password = txb_password.Text;

            string HashPassword = Utilscs.HashPassword(password);
            string position = txb_position.Text;

            int roleID = 2;

            InsertData(code, fullname, position, roleID, username, HashPassword);

        }
        private void InsertData(string code, string name, string position, int roleID, string username, string password)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Employee " +
                "(code, name, position, username, password, active, roleId) VALUES (@code, @name, @position, @username, @password, 1, @roleId)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@roleId", roleID);

                        command.Parameters.AddWithValue("@password", password);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
