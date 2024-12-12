namespace SaleManagementWinform
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.txb_position = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.rbt_admin = new System.Windows.Forms.RadioButton();
            this.rbt_sale = new System.Windows.Forms.RadioButton();
            this.rbt_warehouse = new System.Windows.Forms.RadioButton();
            this.rbt_customer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(266, 25);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(215, 20);
            this.txb_name.TabIndex = 4;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(266, 75);
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(215, 20);
            this.txb_code.TabIndex = 5;
            // 
            // txb_position
            // 
            this.txb_position.Location = new System.Drawing.Point(266, 131);
            this.txb_position.Name = "txb_position";
            this.txb_position.Size = new System.Drawing.Size(215, 20);
            this.txb_position.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(314, 378);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "User name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(266, 304);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(215, 20);
            this.txb_password.TabIndex = 14;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(266, 259);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(215, 20);
            this.txb_username.TabIndex = 15;
            // 
            // rbt_admin
            // 
            this.rbt_admin.AutoSize = true;
            this.rbt_admin.Location = new System.Drawing.Point(266, 177);
            this.rbt_admin.Name = "rbt_admin";
            this.rbt_admin.Size = new System.Drawing.Size(54, 17);
            this.rbt_admin.TabIndex = 16;
            this.rbt_admin.TabStop = true;
            this.rbt_admin.Text = "Admin";
            this.rbt_admin.UseVisualStyleBackColor = true;
            // 
            // rbt_sale
            // 
            this.rbt_sale.AutoSize = true;
            this.rbt_sale.Location = new System.Drawing.Point(266, 217);
            this.rbt_sale.Name = "rbt_sale";
            this.rbt_sale.Size = new System.Drawing.Size(46, 17);
            this.rbt_sale.TabIndex = 17;
            this.rbt_sale.TabStop = true;
            this.rbt_sale.Text = "Sale";
            this.rbt_sale.UseVisualStyleBackColor = true;
            // 
            // rbt_warehouse
            // 
            this.rbt_warehouse.AutoSize = true;
            this.rbt_warehouse.Location = new System.Drawing.Point(392, 177);
            this.rbt_warehouse.Name = "rbt_warehouse";
            this.rbt_warehouse.Size = new System.Drawing.Size(82, 17);
            this.rbt_warehouse.TabIndex = 18;
            this.rbt_warehouse.TabStop = true;
            this.rbt_warehouse.Text = "WareHouse";
            this.rbt_warehouse.UseVisualStyleBackColor = true;
            // 
            // rbt_customer
            // 
            this.rbt_customer.AutoSize = true;
            this.rbt_customer.Location = new System.Drawing.Point(392, 217);
            this.rbt_customer.Name = "rbt_customer";
            this.rbt_customer.Size = new System.Drawing.Size(69, 17);
            this.rbt_customer.TabIndex = 19;
            this.rbt_customer.TabStop = true;
            this.rbt_customer.Text = "Customer";
            this.rbt_customer.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbt_customer);
            this.Controls.Add(this.rbt_warehouse);
            this.Controls.Add(this.rbt_sale);
            this.Controls.Add(this.rbt_admin);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_position);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.txb_name);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.TextBox txb_position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.RadioButton rbt_admin;
        private System.Windows.Forms.RadioButton rbt_sale;
        private System.Windows.Forms.RadioButton rbt_warehouse;
        private System.Windows.Forms.RadioButton rbt_customer;
    }
}