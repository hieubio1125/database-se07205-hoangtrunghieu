﻿namespace SaleManagementWinform
{
    partial class UpdateCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_phoneNumber = new System.Windows.Forms.TextBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "phoneNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "email";
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(244, 38);
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(240, 20);
            this.txb_code.TabIndex = 1;
            this.txb_code.TextChanged += new System.EventHandler(this.txb_code_TextChanged);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(244, 96);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(240, 20);
            this.txb_name.TabIndex = 1;
            // 
            // txb_phoneNumber
            // 
            this.txb_phoneNumber.Location = new System.Drawing.Point(244, 147);
            this.txb_phoneNumber.Name = "txb_phoneNumber";
            this.txb_phoneNumber.Size = new System.Drawing.Size(240, 20);
            this.txb_phoneNumber.TabIndex = 1;
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(244, 206);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(240, 20);
            this.txb_address.TabIndex = 1;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(244, 267);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(240, 20);
            this.txb_email.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "cap nhat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "xoa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_phoneNumber);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_phoneNumber;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}