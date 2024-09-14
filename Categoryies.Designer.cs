
namespace PharmacyManagment
{
    partial class Categoryies
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
            this.Add_category = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShoeBtn = new System.Windows.Forms.Button();
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryName_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_category
            // 
            this.Add_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_category.ForeColor = System.Drawing.Color.White;
            this.Add_category.Location = new System.Drawing.Point(110, 261);
            this.Add_category.Name = "Add_category";
            this.Add_category.Size = new System.Drawing.Size(162, 35);
            this.Add_category.TabIndex = 9;
            this.Add_category.Text = "Add";
            this.Add_category.UseVisualStyleBackColor = false;
            this.Add_category.Click += new System.EventHandler(this.Add_category_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 35);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "CategoryName";
            // 
            // ShoeBtn
            // 
            this.ShoeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShoeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeBtn.ForeColor = System.Drawing.Color.White;
            this.ShoeBtn.Location = new System.Drawing.Point(395, 261);
            this.ShoeBtn.Name = "ShoeBtn";
            this.ShoeBtn.Size = new System.Drawing.Size(162, 35);
            this.ShoeBtn.TabIndex = 10;
            this.ShoeBtn.Text = "Show";
            this.ShoeBtn.UseVisualStyleBackColor = false;
            this.ShoeBtn.Click += new System.EventHandler(this.ShoeBtn_Click);
            // 
            // dgvcart
            // 
            this.dgvcart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName_c,
            this.Description_c});
            this.dgvcart.GridColor = System.Drawing.SystemColors.Control;
            this.dgvcart.Location = new System.Drawing.Point(62, 330);
            this.dgvcart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.Size = new System.Drawing.Size(495, 214);
            this.dgvcart.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Pharm_Project.Properties.Resources.photo_Category;
            this.pictureBox1.Location = new System.Drawing.Point(586, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryName_c
            // 
            this.CategoryName_c.HeaderText = "Category Name";
            this.CategoryName_c.MaxInputLength = 100;
            this.CategoryName_c.Name = "CategoryName_c";
            this.CategoryName_c.Width = 170;
            // 
            // Description_c
            // 
            this.Description_c.HeaderText = "Description";
            this.Description_c.MaxInputLength = 500;
            this.Description_c.Name = "Description_c";
            this.Description_c.Width = 280;
            // 
            // Supplier_info
            // 
            this.Supplier_info.AutoSize = true;
            this.Supplier_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supplier_info.Location = new System.Drawing.Point(197, 59);
            this.Supplier_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Supplier_info.Name = "Supplier_info";
            this.Supplier_info.Size = new System.Drawing.Size(236, 37);
            this.Supplier_info.TabIndex = 25;
            this.Supplier_info.Text = "Category Data";
            // 
            // Categoryies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 496);
            this.Controls.Add(this.Supplier_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvcart);
            this.Controls.Add(this.ShoeBtn);
            this.Controls.Add(this.Add_category);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Categoryies";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_category;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShoeBtn;
        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_c;
        private System.Windows.Forms.Label Supplier_info;
    }
}