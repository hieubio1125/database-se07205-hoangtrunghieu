namespace SaleManagementWinform
{
    partial class AddPurchaseHistory
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
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.tBx_purchaseID = new System.Windows.Forms.TextBox();
            this.tBx_customerID = new System.Windows.Forms.TextBox();
            this.tBx_productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBx_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_datetime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(240, 36);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(219, 21);
            this.cbx_status.TabIndex = 0;
            // 
            // tBx_purchaseID
            // 
            this.tBx_purchaseID.Location = new System.Drawing.Point(240, 88);
            this.tBx_purchaseID.Name = "tBx_purchaseID";
            this.tBx_purchaseID.Size = new System.Drawing.Size(219, 20);
            this.tBx_purchaseID.TabIndex = 1;
            // 
            // tBx_customerID
            // 
            this.tBx_customerID.Location = new System.Drawing.Point(240, 141);
            this.tBx_customerID.Name = "tBx_customerID";
            this.tBx_customerID.Size = new System.Drawing.Size(219, 20);
            this.tBx_customerID.TabIndex = 2;
            // 
            // tBx_productID
            // 
            this.tBx_productID.Location = new System.Drawing.Point(240, 191);
            this.tBx_productID.Name = "tBx_productID";
            this.tBx_productID.Size = new System.Drawing.Size(219, 20);
            this.tBx_productID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trang thai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purchase ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProductID";
            // 
            // tBx_quantity
            // 
            this.tBx_quantity.Location = new System.Drawing.Point(240, 247);
            this.tBx_quantity.Name = "tBx_quantity";
            this.tBx_quantity.Size = new System.Drawing.Size(219, 20);
            this.tBx_quantity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_datetime
            // 
            this.dtp_datetime.Location = new System.Drawing.Point(241, 294);
            this.dtp_datetime.Name = "dtp_datetime";
            this.dtp_datetime.Size = new System.Drawing.Size(200, 20);
            this.dtp_datetime.TabIndex = 11;
            // 
            // AddPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.dtp_datetime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBx_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBx_productID);
            this.Controls.Add(this.tBx_customerID);
            this.Controls.Add(this.tBx_purchaseID);
            this.Controls.Add(this.cbx_status);
            this.Name = "AddPurchaseHistory";
            this.Text = "Add PurchaseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.TextBox tBx_purchaseID;
        private System.Windows.Forms.TextBox tBx_customerID;
        private System.Windows.Forms.TextBox tBx_productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBx_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_datetime;
    }
}