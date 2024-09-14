using Pharm_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class Add_Employee : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        DateTime EmpHiringDat;
        string shift;
        string Gende;
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Add_Emp_Click(object sender, EventArgs e)
        {
            string EmpName = EmpNameInput.Text;
            string Emp_phone = EmpPhoneInput.Text;
            string EmpNID = EmpNIdInput.Text;
            string EmpEmail = EmpEmailInput.Text;
            string EmpSalary = EmpSalaryInput.Text;
            string Emp_Position = EmpPositionInput.Text;
            string Addres = Address.Text;
            DateTime hiring = EmpHiringDat;
            float salary;

            if (string.IsNullOrWhiteSpace(EmpName))
            {
                MessageBox.Show("Please Enter Employee Name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Addres))
            {
                MessageBox.Show("Please Enter Employee Address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(EmpNID) || EmpNID.Length != 14 || !EmpNID.All(char.IsDigit))
            {
                MessageBox.Show("National ID Must be 14 digit number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(EmpEmail) || !EmpEmail.Contains("@") || !EmpEmail.Contains(".com"))
            {
                MessageBox.Show("Email is incorrect, It Must contain @.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Emp_Position))
            {
                MessageBox.Show("Please Enter position for employee.");
                return;
            }

            if (Emp_phone.Length != 11 || !Emp_phone.All(char.IsDigit))
            {
                MessageBox.Show("Incorrect phone number it must be 11 digit number.");
                return;
            }

            if (!float.TryParse(EmpSalary, out salary) || salary <= 0)
            {
                MessageBox.Show("Salary must be positive number.");
                return;
            }


            Employee employee = new Employee();
            employee.Employee_Name = EmpName;
            employee.Employee_Phone = Emp_phone;
            employee.Employee_Email = EmpEmail;
            employee.Position = Emp_Position;
            employee.National_ID = EmpNID;
            employee.Salary = salary;
            employee.Hire_Date = hiring;
            employee.Employee_Shift = shift;
            employee.Gender = Gende;
            employee.Employee_Address = Addres;
            //add database
            try
            {
                var em = context.Employees.FirstOrDefault(x => x.National_ID == EmpNID);
                if (em == null) {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Employee added successfully.");
                }
                else
                {
                    MessageBox.Show("employee is exist before   ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the employee data: " + ex.Message);
            }
        }

        private void EmpHiringDate_ValueChanged(object sender, EventArgs e)
        {
            EmpHiringDat = EmpHiringDate.Value;
        }

        private void CbEmpShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            shift = CbEmpShift.SelectedItem.ToString();
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gende = Gender.SelectedItem.ToString();
        }
    }
}
