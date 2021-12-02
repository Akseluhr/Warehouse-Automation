namespace ProjektOOP2
{
    partial class Form1
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
            this.manageProductsButton = new System.Windows.Forms.Button();
            this.BTNManageCustomers = new System.Windows.Forms.Button();
            this.BTNPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageProductsButton
            // 
            this.manageProductsButton.Location = new System.Drawing.Point(319, 129);
            this.manageProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageProductsButton.Name = "manageProductsButton";
            this.manageProductsButton.Size = new System.Drawing.Size(117, 75);
            this.manageProductsButton.TabIndex = 0;
            this.manageProductsButton.Text = "Manage products";
            this.manageProductsButton.UseVisualStyleBackColor = true;
            this.manageProductsButton.Click += new System.EventHandler(this.manageProductsButton_Click);
            // 
            // BTNManageCustomers
            // 
            this.BTNManageCustomers.Location = new System.Drawing.Point(196, 129);
            this.BTNManageCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNManageCustomers.Name = "BTNManageCustomers";
            this.BTNManageCustomers.Size = new System.Drawing.Size(117, 75);
            this.BTNManageCustomers.TabIndex = 1;
            this.BTNManageCustomers.Text = "Manage customers";
            this.BTNManageCustomers.UseVisualStyleBackColor = true;
            this.BTNManageCustomers.Click += new System.EventHandler(this.BTNManageCustomers_Click);
            // 
            // BTNPlaceOrder
            // 
            this.BTNPlaceOrder.Location = new System.Drawing.Point(73, 129);
            this.BTNPlaceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNPlaceOrder.Name = "BTNPlaceOrder";
            this.BTNPlaceOrder.Size = new System.Drawing.Size(117, 75);
            this.BTNPlaceOrder.TabIndex = 3;
            this.BTNPlaceOrder.Text = "Place an order";
            this.BTNPlaceOrder.UseVisualStyleBackColor = true;
            this.BTNPlaceOrder.Click += new System.EventHandler(this.BTNPlaceOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.BTNPlaceOrder);
            this.Controls.Add(this.BTNManageCustomers);
            this.Controls.Add(this.manageProductsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Warehouse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageProductsButton;
        private System.Windows.Forms.Button BTNManageCustomers;
        private System.Windows.Forms.Button BTNPlaceOrder;
    }
}

