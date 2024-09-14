
namespace PharmacyManagment
{
    partial class Supplierses
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
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.Supplier_info = new System.Windows.Forms.Label();
            this.dgvsuppliers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(623, 188);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(241, 38);
            this.TxtEmail.TabIndex = 35;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(623, 133);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(241, 37);
            this.TxtAddress.TabIndex = 34;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(750, 237);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 38);
            this.BtnUpdate.TabIndex = 32;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.White;
            this.BtnInsert.Location = new System.Drawing.Point(623, 237);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(117, 38);
            this.BtnInsert.TabIndex = 30;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Email.Location = new System.Drawing.Point(509, 188);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(77, 25);
            this.label_Email.TabIndex = 29;
            this.label_Email.Text = "Email :";
            this.label_Email.Click += new System.EventHandler(this.label_Email_Click);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Address.Location = new System.Drawing.Point(497, 136);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(103, 25);
            this.label_Address.TabIndex = 28;
            this.label_Address.Text = "Address :";
            this.label_Address.Click += new System.EventHandler(this.label_Address_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(177, 188);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPhone.Multiline = true;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(259, 38);
            this.TxtPhone.TabIndex = 27;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Phone.Location = new System.Drawing.Point(87, 188);
            this.label_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(86, 25);
            this.label_Phone.TabIndex = 26;
            this.label_Phone.Text = "Phone :";
            this.label_Phone.Click += new System.EventHandler(this.label_Phone_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(177, 133);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(259, 41);
            this.TxtName.TabIndex = 25;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Name.Location = new System.Drawing.Point(87, 136);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(80, 25);
            this.label_Name.TabIndex = 24;
            this.label_Name.Text = "Name :";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // Supplier_info
            // 
            this.Supplier_info.AutoSize = true;
            this.Supplier_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supplier_info.Location = new System.Drawing.Point(362, 50);
            this.Supplier_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Supplier_info.Name = "Supplier_info";
            this.Supplier_info.Size = new System.Drawing.Size(224, 37);
            this.Supplier_info.TabIndex = 23;
            this.Supplier_info.Text = "Supplier Data";
            // 
            // dgvsuppliers
            // 
            this.dgvsuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvsuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvsuppliers.Location = new System.Drawing.Point(58, 295);
            this.dgvsuppliers.Name = "dgvsuppliers";
            this.dgvsuppliers.Size = new System.Drawing.Size(843, 193);
            this.dgvsuppliers.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier Phone";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Supplier Address";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Supplierses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 489);
            this.Controls.Add(this.dgvsuppliers);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.Supplier_info);
            this.Name = "Supplierses";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Supplierses_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label Supplier_info;
        private System.Windows.Forms.DataGridView dgvsuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}