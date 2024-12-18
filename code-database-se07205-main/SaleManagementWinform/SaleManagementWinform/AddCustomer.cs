﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaSP = txb_code.Text;
            string TenKhachHang = txb_name.Text;
            string phoneString = txb_phone.Text;
            string addressString = txb_address.Text;

            int phone, address;

            // Kiểm tra và chuyển đổi dữ liệu an toàn
            if (!int.TryParse(phoneString, out phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            if (!int.TryParse(addressString, out address))
            {
                MessageBox.Show("Địa chỉ không hợp lệ!");
                return;
            }

            // Chuỗi kết nối tới cơ sở dữ liệu

            // Câu lệnh SQL để chèn dữ liệu
            string query = "INSERT INTO Customer (MaSP, TenKhachHang, Phone, Address) VALUES (@MaSP, @TenKhachHang, @Phone, @Address)";

            // Kết nối cơ sở dữ liệu và thực thi lệnh
            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        command.Parameters.AddWithValue("@MaSP", MaSP);
                        command.Parameters.AddWithValue("@TenKhachHang", TenKhachHang);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);

                        // Thực thi lệnh
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm dữ liệu. Vui lòng thử lại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void InsertData(string code, string name, string phone, string address)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Customer (code, name, phoneNumber, address, active) VALUES (@code, @name, @phoneNumber, @address, 1)";

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
                        command.Parameters.AddWithValue("@phoneNumber", phone);
                        command.Parameters.AddWithValue("@address", address);


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            // Cap nhat code moi nhat 
            // update code 

            string MaSP = txb_code.Text.ToString();
            string TenSP = txb_name.Text.ToString();
            string phone = (txb_phone.Text.ToString());
            string  address =(txb_address.Text.ToString());

            InsertData(MaSP, TenSP, phone, address);
        }

        private void txb_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }  
}
