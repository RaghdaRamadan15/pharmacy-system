namespace PharmacyManagment
{
    partial class add_new_product
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
            this.add_product = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_unit_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberUnit_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packag_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Expriation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Product ";
            // 
            // add_product
            // 
            this.add_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product.ForeColor = System.Drawing.Color.White;
            this.add_product.Location = new System.Drawing.Point(346, 463);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(300, 49);
            this.add_product.TabIndex = 2;
            this.add_product.Text = "Add Product";
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name_p,
            this.CategoryName_c,
            this.Price_unit_p,
            this.NumberUnit_n,
            this.Packag_p,
            this.Date_Expriation});
            this.dataGridView1.Location = new System.Drawing.Point(43, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 288);
            this.dataGridView1.TabIndex = 3;
            // 
            // Product_Name_p
            // 
            this.Product_Name_p.HeaderText = "Product_Name";
            this.Product_Name_p.Name = "Product_Name_p";
            this.Product_Name_p.ReadOnly = true;
            this.Product_Name_p.Width = 150;
            // 
            // CategoryName_c
            // 
            this.CategoryName_c.HeaderText = "CategoryName";
            this.CategoryName_c.Name = "CategoryName_c";
            this.CategoryName_c.ReadOnly = true;
            this.CategoryName_c.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryName_c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CategoryName_c.Width = 180;
            // 
            // Price_unit_p
            // 
            this.Price_unit_p.HeaderText = "Price";
            this.Price_unit_p.Name = "Price_unit_p";
            this.Price_unit_p.ReadOnly = true;
            // 
            // NumberUnit_n
            // 
            this.NumberUnit_n.HeaderText = "NumberUnit";
            this.NumberUnit_n.Name = "NumberUnit_n";
            this.NumberUnit_n.ReadOnly = true;
            // 
            // Packag_p
            // 
            this.Packag_p.HeaderText = "PackagNumber";
            this.Packag_p.Name = "Packag_p";
            this.Packag_p.ReadOnly = true;
            // 
            // Date_Expriation
            // 
            this.Date_Expriation.HeaderText = "DateExpriation";
            this.Date_Expriation.Name = "Date_Expriation";
            this.Date_Expriation.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Supolier Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "NumberUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PackagNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // add_new_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.label1);
            this.Name = "add_new_product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.add_new_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_unit_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberUnit_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packag_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Expriation;
    }
}