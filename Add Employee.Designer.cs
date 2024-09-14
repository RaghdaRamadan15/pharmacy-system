
namespace PharmacyManagment
{
    partial class Add_Employee
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
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbEmpShift = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Add_Emp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpSalaryInput = new System.Windows.Forms.TextBox();
            this.EmpPositionInput = new System.Windows.Forms.TextBox();
            this.EmpEmailInput = new System.Windows.Forms.TextBox();
            this.EmpPhoneInput = new System.Windows.Forms.TextBox();
            this.EmpHiringDate = new System.Windows.Forms.DateTimePicker();
            this.EmpNIdInput = new System.Windows.Forms.TextBox();
            this.EmpNameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Famale"});
            this.Gender.Location = new System.Drawing.Point(655, 232);
            this.Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(230, 33);
            this.Gender.TabIndex = 59;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(527, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Gender";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Calibri", 19.8F);
            this.Address.Location = new System.Drawing.Point(231, 232);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(267, 40);
            this.Address.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Address";
            // 
            // CbEmpShift
            // 
            this.CbEmpShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.CbEmpShift.FormattingEnabled = true;
            this.CbEmpShift.Items.AddRange(new object[] {
            "Am",
            "Pm"});
            this.CbEmpShift.Location = new System.Drawing.Point(655, 359);
            this.CbEmpShift.Margin = new System.Windows.Forms.Padding(2);
            this.CbEmpShift.Name = "CbEmpShift";
            this.CbEmpShift.Size = new System.Drawing.Size(230, 33);
            this.CbEmpShift.TabIndex = 55;
            this.CbEmpShift.SelectedIndexChanged += new System.EventHandler(this.CbEmpShift_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(527, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Shift";
            // 
            // Add_Emp
            // 
            this.Add_Emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Add_Emp.ForeColor = System.Drawing.Color.White;
            this.Add_Emp.Location = new System.Drawing.Point(231, 430);
            this.Add_Emp.Name = "Add_Emp";
            this.Add_Emp.Size = new System.Drawing.Size(271, 44);
            this.Add_Emp.TabIndex = 53;
            this.Add_Emp.Text = "Add";
            this.Add_Emp.UseVisualStyleBackColor = false;
            this.Add_Emp.Click += new System.EventHandler(this.Add_Emp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(306, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Add New Employee";
            // 
            // EmpSalaryInput
            // 
            this.EmpSalaryInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryInput.Location = new System.Drawing.Point(655, 294);
            this.EmpSalaryInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpSalaryInput.Multiline = true;
            this.EmpSalaryInput.Name = "EmpSalaryInput";
            this.EmpSalaryInput.Size = new System.Drawing.Size(230, 40);
            this.EmpSalaryInput.TabIndex = 51;
            // 
            // EmpPositionInput
            // 
            this.EmpPositionInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPositionInput.Location = new System.Drawing.Point(231, 296);
            this.EmpPositionInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpPositionInput.Multiline = true;
            this.EmpPositionInput.Name = "EmpPositionInput";
            this.EmpPositionInput.Size = new System.Drawing.Size(267, 38);
            this.EmpPositionInput.TabIndex = 50;
            // 
            // EmpEmailInput
            // 
            this.EmpEmailInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEmailInput.Location = new System.Drawing.Point(655, 163);
            this.EmpEmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpEmailInput.Multiline = true;
            this.EmpEmailInput.Name = "EmpEmailInput";
            this.EmpEmailInput.Size = new System.Drawing.Size(230, 42);
            this.EmpEmailInput.TabIndex = 49;
            // 
            // EmpPhoneInput
            // 
            this.EmpPhoneInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneInput.Location = new System.Drawing.Point(231, 163);
            this.EmpPhoneInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpPhoneInput.Multiline = true;
            this.EmpPhoneInput.Name = "EmpPhoneInput";
            this.EmpPhoneInput.Size = new System.Drawing.Size(267, 42);
            this.EmpPhoneInput.TabIndex = 48;
            // 
            // EmpHiringDate
            // 
            this.EmpHiringDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpHiringDate.Location = new System.Drawing.Point(231, 368);
            this.EmpHiringDate.Margin = new System.Windows.Forms.Padding(2);
            this.EmpHiringDate.Name = "EmpHiringDate";
            this.EmpHiringDate.Size = new System.Drawing.Size(267, 26);
            this.EmpHiringDate.TabIndex = 47;
            this.EmpHiringDate.ValueChanged += new System.EventHandler(this.EmpHiringDate_ValueChanged);
            // 
            // EmpNIdInput
            // 
            this.EmpNIdInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNIdInput.Location = new System.Drawing.Point(655, 103);
            this.EmpNIdInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpNIdInput.Multiline = true;
            this.EmpNIdInput.Name = "EmpNIdInput";
            this.EmpNIdInput.Size = new System.Drawing.Size(230, 38);
            this.EmpNIdInput.TabIndex = 46;
            // 
            // EmpNameInput
            // 
            this.EmpNameInput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameInput.Location = new System.Drawing.Point(231, 100);
            this.EmpNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmpNameInput.Multiline = true;
            this.EmpNameInput.Name = "EmpNameInput";
            this.EmpNameInput.Size = new System.Drawing.Size(267, 40);
            this.EmpNameInput.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(75, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hiring Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(527, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(76, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(527, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(75, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(527, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(75, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbEmpShift);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Add_Emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpSalaryInput);
            this.Controls.Add(this.EmpPositionInput);
            this.Controls.Add(this.EmpEmailInput);
            this.Controls.Add(this.EmpPhoneInput);
            this.Controls.Add(this.EmpHiringDate);
            this.Controls.Add(this.EmpNIdInput);
            this.Controls.Add(this.EmpNameInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Add_Employee";
            this.Text = "Add_Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbEmpShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Add_Emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpSalaryInput;
        private System.Windows.Forms.TextBox EmpPositionInput;
        private System.Windows.Forms.TextBox EmpEmailInput;
        private System.Windows.Forms.TextBox EmpPhoneInput;
        private System.Windows.Forms.DateTimePicker EmpHiringDate;
        private System.Windows.Forms.TextBox EmpNIdInput;
        private System.Windows.Forms.TextBox EmpNameInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}