
namespace PharmacyManagment
{
    partial class Update_Employee
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
            this.BtnShowEmp = new System.Windows.Forms.Button();
            this.BtnUpdateEmp = new System.Windows.Forms.Button();
            this.EmpVwDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEmpSearch = new System.Windows.Forms.Button();
            this.EmpSearchInput = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmpVwDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowEmp
            // 
            this.BtnShowEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnShowEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowEmp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowEmp.ForeColor = System.Drawing.Color.White;
            this.BtnShowEmp.Location = new System.Drawing.Point(84, 385);
            this.BtnShowEmp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnShowEmp.Name = "BtnShowEmp";
            this.BtnShowEmp.Size = new System.Drawing.Size(102, 39);
            this.BtnShowEmp.TabIndex = 24;
            this.BtnShowEmp.Text = "Show";
            this.BtnShowEmp.UseVisualStyleBackColor = false;
            this.BtnShowEmp.Click += new System.EventHandler(this.BtnShowEmp_Click);
            // 
            // BtnUpdateEmp
            // 
            this.BtnUpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateEmp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateEmp.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateEmp.Location = new System.Drawing.Point(711, 385);
            this.BtnUpdateEmp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateEmp.Name = "BtnUpdateEmp";
            this.BtnUpdateEmp.Size = new System.Drawing.Size(101, 39);
            this.BtnUpdateEmp.TabIndex = 23;
            this.BtnUpdateEmp.Text = "Update";
            this.BtnUpdateEmp.UseVisualStyleBackColor = false;
            this.BtnUpdateEmp.Click += new System.EventHandler(this.BtnUpdateEmp_Click);
            // 
            // EmpVwDataGrid
            // 
            this.EmpVwDataGrid.AllowUserToOrderColumns = true;
            this.EmpVwDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpVwDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpVwDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.Emp_Phone,
            this.EmpEmail,
            this.Emp_Position,
            this.EmpSalary});
            this.EmpVwDataGrid.Location = new System.Drawing.Point(84, 181);
            this.EmpVwDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EmpVwDataGrid.Name = "EmpVwDataGrid";
            this.EmpVwDataGrid.RowHeadersWidth = 51;
            this.EmpVwDataGrid.RowTemplate.Height = 24;
            this.EmpVwDataGrid.Size = new System.Drawing.Size(728, 188);
            this.EmpVwDataGrid.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(278, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modify Employees";
            // 
            // BtnEmpSearch
            // 
            this.BtnEmpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpSearch.ForeColor = System.Drawing.Color.White;
            this.BtnEmpSearch.Location = new System.Drawing.Point(534, 124);
            this.BtnEmpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEmpSearch.Name = "BtnEmpSearch";
            this.BtnEmpSearch.Size = new System.Drawing.Size(102, 37);
            this.BtnEmpSearch.TabIndex = 18;
            this.BtnEmpSearch.Text = "Search";
            this.BtnEmpSearch.UseVisualStyleBackColor = false;
            this.BtnEmpSearch.Click += new System.EventHandler(this.BtnEmpSearch_Click);
            // 
            // EmpSearchInput
            // 
            this.EmpSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSearchInput.Location = new System.Drawing.Point(261, 124);
            this.EmpSearchInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpSearchInput.Multiline = true;
            this.EmpSearchInput.Name = "EmpSearchInput";
            this.EmpSearchInput.Size = new System.Drawing.Size(216, 37);
            this.EmpSearchInput.TabIndex = 17;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 135;
            // 
            // Emp_Phone
            // 
            this.Emp_Phone.HeaderText = "Phone";
            this.Emp_Phone.MinimumWidth = 6;
            this.Emp_Phone.Name = "Emp_Phone";
            this.Emp_Phone.Width = 135;
            // 
            // EmpEmail
            // 
            this.EmpEmail.HeaderText = "Email";
            this.EmpEmail.MinimumWidth = 6;
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Width = 135;
            // 
            // Emp_Position
            // 
            this.Emp_Position.HeaderText = "Position";
            this.Emp_Position.MinimumWidth = 6;
            this.Emp_Position.Name = "Emp_Position";
            this.Emp_Position.Width = 135;
            // 
            // EmpSalary
            // 
            this.EmpSalary.HeaderText = "Salary";
            this.EmpSalary.MinimumWidth = 6;
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Width = 135;
            // 
            // Update_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 469);
            this.Controls.Add(this.BtnShowEmp);
            this.Controls.Add(this.BtnUpdateEmp);
            this.Controls.Add(this.EmpVwDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEmpSearch);
            this.Controls.Add(this.EmpSearchInput);
            this.Name = "Update_Employee";
            this.Text = "Update_Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmpVwDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowEmp;
        private System.Windows.Forms.Button BtnUpdateEmp;
        private System.Windows.Forms.DataGridView EmpVwDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEmpSearch;
        private System.Windows.Forms.TextBox EmpSearchInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalary;
    }
}