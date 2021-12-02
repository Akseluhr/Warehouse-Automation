namespace ProjektOOP2
{
    partial class CustomerManagement
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
            this.LSTCustomers = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.TXTCustomerName = new System.Windows.Forms.TextBox();
            this.TXTCustomerPhone = new System.Windows.Forms.TextBox();
            this.TXTCustomerEmail = new System.Windows.Forms.TextBox();
            this.BTNAddCustomer = new System.Windows.Forms.Button();
            this.BTNUpdateCustomerName = new System.Windows.Forms.Button();
            this.BTNUpdateCustomerPhone = new System.Windows.Forms.Button();
            this.BTNUpdateCustomerEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LSTCustomers
            // 
            this.LSTCustomers.FormattingEnabled = true;
            this.LSTCustomers.ItemHeight = 16;
            this.LSTCustomers.Location = new System.Drawing.Point(11, 10);
            this.LSTCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LSTCustomers.Name = "LSTCustomers";
            this.LSTCustomers.Size = new System.Drawing.Size(240, 292);
            this.LSTCustomers.TabIndex = 0;
            this.LSTCustomers.SelectedIndexChanged += new System.EventHandler(this.LSTCustomers_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(265, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(265, 38);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(265, 66);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // TXTCustomerName
            // 
            this.TXTCustomerName.Location = new System.Drawing.Point(327, 10);
            this.TXTCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCustomerName.Name = "TXTCustomerName";
            this.TXTCustomerName.Size = new System.Drawing.Size(148, 22);
            this.TXTCustomerName.TabIndex = 4;
            // 
            // TXTCustomerPhone
            // 
            this.TXTCustomerPhone.Location = new System.Drawing.Point(327, 38);
            this.TXTCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCustomerPhone.Name = "TXTCustomerPhone";
            this.TXTCustomerPhone.Size = new System.Drawing.Size(148, 22);
            this.TXTCustomerPhone.TabIndex = 5;
            // 
            // TXTCustomerEmail
            // 
            this.TXTCustomerEmail.Location = new System.Drawing.Point(327, 63);
            this.TXTCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCustomerEmail.Name = "TXTCustomerEmail";
            this.TXTCustomerEmail.Size = new System.Drawing.Size(148, 22);
            this.TXTCustomerEmail.TabIndex = 6;
            // 
            // BTNAddCustomer
            // 
            this.BTNAddCustomer.Location = new System.Drawing.Point(268, 100);
            this.BTNAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAddCustomer.Name = "BTNAddCustomer";
            this.BTNAddCustomer.Size = new System.Drawing.Size(148, 63);
            this.BTNAddCustomer.TabIndex = 7;
            this.BTNAddCustomer.Text = "Add Customer";
            this.BTNAddCustomer.UseVisualStyleBackColor = true;
            this.BTNAddCustomer.Click += new System.EventHandler(this.BTNAddCustomer_Click);
            // 
            // BTNUpdateCustomerName
            // 
            this.BTNUpdateCustomerName.Location = new System.Drawing.Point(492, 9);
            this.BTNUpdateCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNUpdateCustomerName.Name = "BTNUpdateCustomerName";
            this.BTNUpdateCustomerName.Size = new System.Drawing.Size(200, 23);
            this.BTNUpdateCustomerName.TabIndex = 8;
            this.BTNUpdateCustomerName.Text = "Update customer name";
            this.BTNUpdateCustomerName.UseVisualStyleBackColor = true;
            this.BTNUpdateCustomerName.Click += new System.EventHandler(this.BTNUpdateCustomerName_Click);
            // 
            // BTNUpdateCustomerPhone
            // 
            this.BTNUpdateCustomerPhone.Location = new System.Drawing.Point(492, 34);
            this.BTNUpdateCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNUpdateCustomerPhone.Name = "BTNUpdateCustomerPhone";
            this.BTNUpdateCustomerPhone.Size = new System.Drawing.Size(200, 25);
            this.BTNUpdateCustomerPhone.TabIndex = 9;
            this.BTNUpdateCustomerPhone.Text = "Update customer phone";
            this.BTNUpdateCustomerPhone.UseVisualStyleBackColor = true;
            this.BTNUpdateCustomerPhone.Click += new System.EventHandler(this.BTNUpdateCustomerPhone_Click);
            // 
            // BTNUpdateCustomerEmail
            // 
            this.BTNUpdateCustomerEmail.Location = new System.Drawing.Point(492, 61);
            this.BTNUpdateCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNUpdateCustomerEmail.Name = "BTNUpdateCustomerEmail";
            this.BTNUpdateCustomerEmail.Size = new System.Drawing.Size(200, 24);
            this.BTNUpdateCustomerEmail.TabIndex = 10;
            this.BTNUpdateCustomerEmail.Text = "Update customer Email";
            this.BTNUpdateCustomerEmail.UseVisualStyleBackColor = true;
            this.BTNUpdateCustomerEmail.Click += new System.EventHandler(this.BTNUpdateCustomerEmail_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 325);
            this.Controls.Add(this.BTNUpdateCustomerEmail);
            this.Controls.Add(this.BTNUpdateCustomerPhone);
            this.Controls.Add(this.BTNUpdateCustomerName);
            this.Controls.Add(this.BTNAddCustomer);
            this.Controls.Add(this.TXTCustomerEmail);
            this.Controls.Add(this.TXTCustomerPhone);
            this.Controls.Add(this.TXTCustomerName);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.LSTCustomers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTCustomers;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox TXTCustomerName;
        private System.Windows.Forms.TextBox TXTCustomerPhone;
        private System.Windows.Forms.TextBox TXTCustomerEmail;
        private System.Windows.Forms.Button BTNAddCustomer;
        private System.Windows.Forms.Button BTNUpdateCustomerName;
        private System.Windows.Forms.Button BTNUpdateCustomerPhone;
        private System.Windows.Forms.Button BTNUpdateCustomerEmail;
    }
}