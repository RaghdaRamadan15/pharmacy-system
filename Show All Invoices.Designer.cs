
namespace PharmacyManagment
{
    partial class Show_All_Invoices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerstart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerend = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInvoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_showInvoices = new System.Windows.Forms.DataGridView();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerstart);
            this.groupBox1.Controls.Add(this.dateTimePickerend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(79, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 82);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // dateTimePickerstart
            // 
            this.dateTimePickerstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerstart.Location = new System.Drawing.Point(67, 40);
            this.dateTimePickerstart.Name = "dateTimePickerstart";
            this.dateTimePickerstart.Size = new System.Drawing.Size(283, 26);
            this.dateTimePickerstart.TabIndex = 4;
            // 
            // dateTimePickerend
            // 
            this.dateTimePickerend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerend.Location = new System.Drawing.Point(504, 40);
            this.dateTimePickerend.Name = "dateTimePickerend";
            this.dateTimePickerend.Size = new System.Drawing.Size(283, 26);
            this.dateTimePickerend.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // comboBoxInvoices
            // 
            this.comboBoxInvoices.FormattingEnabled = true;
            this.comboBoxInvoices.Location = new System.Drawing.Point(214, 92);
            this.comboBoxInvoices.Name = "comboBoxInvoices";
            this.comboBoxInvoices.Size = new System.Drawing.Size(283, 33);
            this.comboBoxInvoices.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Invoice Type";
            // 
            // dgv_showInvoices
            // 
            this.dgv_showInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_showInvoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_showInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_showInvoices.ColumnHeadersHeight = 40;
            this.dgv_showInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_showInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_showInvoices.Location = new System.Drawing.Point(79, 252);
            this.dgv_showInvoices.Name = "dgv_showInvoices";
            this.dgv_showInvoices.ReadOnly = true;
            this.dgv_showInvoices.RowHeadersWidth = 80;
            this.dgv_showInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_showInvoices.Size = new System.Drawing.Size(812, 269);
            this.dgv_showInvoices.TabIndex = 10;
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.Location = new System.Drawing.Point(711, 83);
            this.ShowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(178, 49);
            this.ShowBtn.TabIndex = 20;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(310, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 37);
            this.label4.TabIndex = 41;
            this.label4.Text = "All Invoices";
            // 
            // Show_All_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.dgv_showInvoices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxInvoices);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Show_All_Invoices";
            this.Text = "Show_All_Invoices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerstart;
        private System.Windows.Forms.DateTimePicker dateTimePickerend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_showInvoices;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label label4;
    }
}