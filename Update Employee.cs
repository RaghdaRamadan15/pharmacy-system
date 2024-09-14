using Pharm_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class Update_Employee : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        public Update_Employee()
        {
            InitializeComponent();
        }

        private void BtnEmpSearch_Click(object sender, EventArgs e)
        {
            EmpVwDataGrid.ReadOnly = false;
 EmpVwDataGrid.Rows.Clear();
 string EmpSearch = EmpSearchInput.Text;

 if (string.IsNullOrWhiteSpace(EmpSearch))
 {
     MessageBox.Show("Please enter employee name to search.");
     return;
 }

 var empSearch = context.Employees.Where(x => x.Employee_Name == EmpSearch).ToList();

 if (empSearch.Count>0)
 {
     foreach (var item in empSearch)
     {
        
         bool isExist = false;

         foreach (DataGridViewRow rows in EmpVwDataGrid.Rows)
         {
             if (rows.Cells[0].Value != null && rows.Cells[0].Value.ToString() == item.Employee_Name &&
                 rows.Cells[1].Value != null && rows.Cells[1].Value.ToString() == item.Employee_Phone)
             {
                 isExist = true;
                 break;
             }
         }

         if (!isExist)
         {
             int index = EmpVwDataGrid.Rows.Add();
             DataGridViewRow row = EmpVwDataGrid.Rows[index];
             row.Cells[0].Value = item.Employee_Name;
             row.Cells[1].Value = item.Employee_Phone;
             row.Cells[2].Value = item.Employee_Email;
             row.Cells[3].Value = item.Position;
             row.Cells[4].Value = item.Salary;

            
             row.Tag = item;
         }
     }
 }
 else
 {
     MessageBox.Show("No employee found with that name.");
 }
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
             try
 {
     foreach (DataGridViewRow row in EmpVwDataGrid.Rows)
     {
         
         var emp = row.Tag as Employee;

         if (emp != null)
         {
             
             emp.Employee_Name = row.Cells[0].Value.ToString();
             emp.Employee_Phone = row.Cells[1].Value.ToString();
             emp.Employee_Email = row.Cells[2].Value.ToString();
             emp.Position = row.Cells[3].Value.ToString();

             if (float.TryParse(row.Cells[4].Value.ToString(), out float salary))
             {
                 emp.Salary = salary;
             }
             else
             {
                 MessageBox.Show($"Please enter a valid number for salary in row {row.Index + 1}.");
                 return;
             }

             
             context.Entry(emp).State = EntityState.Modified;
         }
     }

     
     context.SaveChanges();
     MessageBox.Show("All employee details updated successfully.");
 }
 catch (Exception ex)
 {
     MessageBox.Show($"An error occurred: {ex.Message}");
 }
        }

        private void BtnEmpDelete_Click(object sender, EventArgs e)
        {
            string EmpSearch = EmpSearchInput.Text;

            var empSearch = context.Employees.FirstOrDefault(x => x.Employee_Name == EmpSearch);
            if (empSearch != null)
            {

                context.Employees.Remove(empSearch);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Employee is not found");
            }
        }

        private void BtnShowEmp_Click(object sender, EventArgs e)
        {
            EmpVwDataGrid.Rows.Clear();
            EmpVwDataGrid.ReadOnly = true;
            var empSearch = context.Employees;
            if (empSearch != null)
            {
                foreach (var item in empSearch)
                {
                    int index = EmpVwDataGrid.Rows.Add();
                    DataGridViewRow row = EmpVwDataGrid.Rows[index];
                    row.Cells[0].Value = item.Employee_Name;
                    row.Cells[1].Value = item.Employee_Phone;
                    row.Cells[2].Value = item.Employee_Email;
                    row.Cells[3].Value = item.Position;
                    row.Cells[4].Value = item.Salary;


                }
            }
        }
    }
}
