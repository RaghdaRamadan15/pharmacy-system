namespace PharmacyManagment
{
    partial class Employee_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sellMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnSupplierInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReturnInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expirationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellMedicineToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sellMedicineToolStripMenuItem
            // 
            this.sellMedicineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sellMedicineToolStripMenuItem.Name = "sellMedicineToolStripMenuItem";
            this.sellMedicineToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.sellMedicineToolStripMenuItem.Text = "Sell Medicine";
            this.sellMedicineToolStripMenuItem.Click += new System.EventHandler(this.sellMedicineToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierInvoicesToolStripMenuItem,
            this.returnSupplierInvoicesToolStripMenuItem,
            this.customerReturnInvoicesToolStripMenuItem});
            this.invoicesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.invoicesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.ShowShortcutKeys = false;
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // supplierInvoicesToolStripMenuItem
            // 
            this.supplierInvoicesToolStripMenuItem.Name = "supplierInvoicesToolStripMenuItem";
            this.supplierInvoicesToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.supplierInvoicesToolStripMenuItem.Text = "Supplier Invoices";
            this.supplierInvoicesToolStripMenuItem.Click += new System.EventHandler(this.supplierInvoicesToolStripMenuItem_Click);
            // 
            // returnSupplierInvoicesToolStripMenuItem
            // 
            this.returnSupplierInvoicesToolStripMenuItem.Name = "returnSupplierInvoicesToolStripMenuItem";
            this.returnSupplierInvoicesToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.returnSupplierInvoicesToolStripMenuItem.Text = "Return Supplier Invoices";
            this.returnSupplierInvoicesToolStripMenuItem.Click += new System.EventHandler(this.returnSupplierInvoicesToolStripMenuItem_Click);
            // 
            // customerReturnInvoicesToolStripMenuItem
            // 
            this.customerReturnInvoicesToolStripMenuItem.Name = "customerReturnInvoicesToolStripMenuItem";
            this.customerReturnInvoicesToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.customerReturnInvoicesToolStripMenuItem.Text = "Customer Return Invoices";
            this.customerReturnInvoicesToolStripMenuItem.Click += new System.EventHandler(this.customerReturnInvoicesToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expirationDateToolStripMenuItem,
            this.lowStockToolStripMenuItem});
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.logoutToolStripMenuItem.Text = "Notificetion";
            // 
            // expirationDateToolStripMenuItem
            // 
            this.expirationDateToolStripMenuItem.Name = "expirationDateToolStripMenuItem";
            this.expirationDateToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.expirationDateToolStripMenuItem.Text = "Expiration Date";
            this.expirationDateToolStripMenuItem.Click += new System.EventHandler(this.expirationDateToolStripMenuItem_Click);
            // 
            // lowStockToolStripMenuItem
            // 
            this.lowStockToolStripMenuItem.Name = "lowStockToolStripMenuItem";
            this.lowStockToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.lowStockToolStripMenuItem.Text = "Low Stock";
            this.lowStockToolStripMenuItem.Click += new System.EventHandler(this.lowStockToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(97, 34);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(193, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 659);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dr: Gahad Mohamed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Pharm_Project.Properties.Resources.WhatsApp_Image_2024_08_24_at_20_07_18_2b84038c;
            this.pictureBox1.Location = new System.Drawing.Point(0, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1209, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee_main";
            this.Text = "Employee Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnSupplierInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReturnInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expirationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}