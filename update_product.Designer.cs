namespace PharmacyManagment
{
    partial class update_product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.text_medicine = new System.Windows.Forms.TextBox();
            this.Supplier_info = new System.Windows.Forms.Label();
            this.Product_Name_up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_unit_up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagNumber_up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine";
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Location = new System.Drawing.Point(638, 129);
            this.Search_button.Margin = new System.Windows.Forms.Padding(1);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(152, 42);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name_up,
            this.Price_unit_up,
            this.PackagNumber_up});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(44, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(638, 447);
            this.button_update.Margin = new System.Windows.Forms.Padding(1);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(152, 41);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // text_medicine
            // 
            this.text_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_medicine.Location = new System.Drawing.Point(215, 129);
            this.text_medicine.Multiline = true;
            this.text_medicine.Name = "text_medicine";
            this.text_medicine.Size = new System.Drawing.Size(295, 42);
            this.text_medicine.TabIndex = 5;
            this.text_medicine.TextChanged += new System.EventHandler(this.text_medicine_TextChanged);
            // 
            // Supplier_info
            // 
            this.Supplier_info.AutoSize = true;
            this.Supplier_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supplier_info.Location = new System.Drawing.Point(298, 54);
            this.Supplier_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Supplier_info.Name = "Supplier_info";
            this.Supplier_info.Size = new System.Drawing.Size(254, 37);
            this.Supplier_info.TabIndex = 24;
            this.Supplier_info.Text = "Update Product";
            // 
            // Product_Name_up
            // 
            this.Product_Name_up.HeaderText = "Product_Name";
            this.Product_Name_up.Name = "Product_Name_up";
            this.Product_Name_up.Width = 250;
            // 
            // Price_unit_up
            // 
            this.Price_unit_up.HeaderText = "Price_unit";
            this.Price_unit_up.Name = "Price_unit_up";
            this.Price_unit_up.Width = 250;
            // 
            // PackagNumber_up
            // 
            this.PackagNumber_up.HeaderText = "PackagNumber";
            this.PackagNumber_up.Name = "PackagNumber_up";
            this.PackagNumber_up.Width = 250;
            // 
            // update_product
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 508);
            this.Controls.Add(this.Supplier_info);
            this.Controls.Add(this.text_medicine);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_product";
            this.Text = "update_product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox text_medicine;
        private System.Windows.Forms.Label Supplier_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_unit_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagNumber_up;
    }
}