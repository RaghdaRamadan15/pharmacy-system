using Pharm_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class Form1 : Form
    {
        //String connectionString = @"Data Source=(local);Initial Catalog=Pharmacy;Integrated Security=True;TrustServerCertificate=True";
        Pharmacy2Entities context = new Pharmacy2Entities();

        public Form1()
        {
            InitializeComponent();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_Password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }
     
        private void login_btn_Click(object sender, EventArgs e)
        {
            // التحقق من الحقول الفارغة
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_Password.Text))
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من صحة البريد الإلكتروني
            if (!ValidateEmail(login_username.Text))
            {
                MessageBox.Show("Invalid Email Format", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // البحث عن المستخدم في قاعدة البيانات باستخدام LINQ
            var user = context.Pharmacy_Useres.FirstOrDefault(s => s.Employee_Email == login_username.Text && s.passwords == login_Password.Text);

            if (user != null)
            {
                string role = user.Role;
                if (role == "Admin")
                {
                    MessageBox.Show("Login Successfully as Admin!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main mainform = new main();
                    // إخفاء نموذج تسجيل الدخول
                    mainform.Show();
                    this.Hide();
                    //this.Show();
                }
                else 
                {
                    MessageBox.Show("Login Successfully as Employee!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Employee_main employeeMain = new Employee_main();
                    // إخفاء نموذج تسجيل الدخول
                    employeeMain.Show();
                    this.Hide();
                    //this.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password or you need Admins approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateEmail(string email)
        {
            // نمط Regex للتحقق من البريد الإلكتروني
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

       
    }
}
