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
    public partial class CustomerForm : Form
    {

       

        public CustomerForm()
        {
            InitializeComponent();


            this.WindowState = FormWindowState.Maximized;

    
            this.FormBorderStyle = FormBorderStyle.Sizable;


            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();
           

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if the cell belongs to the Edit or Delete button columns
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgv_customer.Columns[e.ColumnIndex].Name == "Edit" || dgv_customer.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Prevent default button painting
                    e.PaintBackground(e.CellBounds, true);

                    // Create a solid brush for button background
                    Brush buttonBrush;
                    if (dgv_customer.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        buttonBrush = new SolidBrush(Color.Green); // Green for Edit
                    }
                    else
                    {
                        buttonBrush = new SolidBrush(Color.Red); // Red for Delete
                    }

                    // Draw the button with the custom color
                    e.Graphics.FillRectangle(buttonBrush, e.CellBounds);

                    // Draw the button text
                    TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true; // Prevent default cell painting
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell belongs to the Edit or Delete button columns
            if (dgv_customer.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Set the background color for the Edit button to green

                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgv_customer.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Set the background color for the Delete button to red
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Customer";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }




 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_customer.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["Code"].Value.ToString();
                var name = selectedRow.Cells["Name"].Value.ToString();
                var price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                var quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                // Display data in textboxes or labels, or use it as needed
                /*  txtID.Text = id.ToString();
                  txtName.Text = name;
                  txtAge.Text = age.ToString();*/

                // MessageBox.Show($"Code  : {code}, Name: {name}, Price: {price},  Quantity: {quantity}");


                UpdateProduct updateProduct = new UpdateProduct(code, name, price, quantity);
                updateProduct.ShowDialog();

            }
        }
        private void dgv_product_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddProductForm form = new AddProductForm();

            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            LoadData();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer ();

            form.ShowDialog();
        }
    }
}
