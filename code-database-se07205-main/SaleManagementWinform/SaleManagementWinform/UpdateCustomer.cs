using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SaleManagementWinform
{
    public partial class UpdateCustomer : Form
    {
        public static string SQLConnection
       = "Server=HIU-CHUNN;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public UpdateCustomer(string code, string name, string phoneNumber, string address)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Disable the maximize/restore button
            this.MaximizeBox = false;
            txb_code.Text = code;
            txb_name.Text = name;
            txb_phoneNumber.Text = phoneNumber.ToString();
            txb_address.Text = address.ToString();
           // txb_email.Text = email.ToString();

        }
        private void UpdateCustomerInDatabase(string code, string name, string phonenumber, string address, string email)
        {
            string query = "UPDATE Customer SET Name = @Name, PhoneNumber = @PhoneNumber, Address = @Address,  WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                        command.Parameters.AddWithValue("@Address", address);
                        

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void DeleteCustomerFromDatabase(string code)
        {
            string query = "DELETE FROM Product WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);

                        // Execute the delete command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy thông tin từ TextBox
            if (string.IsNullOrWhiteSpace(txb_code.Text) ||
                string.IsNullOrWhiteSpace(txb_name.Text) ||
                string.IsNullOrWhiteSpace(txb_phoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txb_address.Text))
          //  string.IsNullOrWhiteSpace(txb_email.Text))c

               

            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.");
                return;
            }

            // Gọi phương thức cập nhật
            UpdateCustomerInDatabase(txb_code.Text, txb_name.Text, txb_phoneNumber.Text, txb_address.Text, txb_email.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the product code from the textbox
            string code = txb_code.Text.Trim();

            // Confirm before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the product from the database
                DeleteCustomerFromDatabase(txb_code.Text.ToString());
            }
        }

        private void txb_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
