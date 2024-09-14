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
    public partial class Employee_main : Form
    {
        ExpirationChecker expirationChecker;
        lowStock_p lowStock_P;
        public Employee_main()
        {
            InitializeComponent();
            expirationChecker = new ExpirationChecker();
            lowStock_P = new lowStock_p();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            LoadFormInPanel(dashBoard);
        }

        private void sellMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell_Medicine sell_Medicine = new Sell_Medicine();
            LoadFormInPanel(sell_Medicine);
        }

        private void supplierInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Invoic Supplier_Invoic = new Supplier_Invoic();
            LoadFormInPanel(Supplier_Invoic);
        }

        private void returnSupplierInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Supplierses return_Supplierses = new Return_Supplierses();
            LoadFormInPanel(return_Supplierses);
        }

        private void customerReturnInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Returnes customer_Returnes = new Customer_Returnes();
            LoadFormInPanel(customer_Returnes);
        }

        private void showAllInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_All_Invoices show_All_Invoices = new Show_All_Invoices();
            LoadFormInPanel(show_All_Invoices);
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoryies Categoryies = new Categoryies();
            LoadFormInPanel(Categoryies);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_product update_product = new update_product();
            LoadFormInPanel(update_product);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplierses supplierses = new Supplierses();
            LoadFormInPanel(supplierses);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee();
            LoadFormInPanel(add_Employee);
        }

        private void modifyEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Employee update_Employee = new Update_Employee();
            LoadFormInPanel(update_Employee);
        }

        

        

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void expirationDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            LoadFormInPanel(notification);
        }

        private void profitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profit profit = new Profit();
            LoadFormInPanel(profit);
        }

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowNotification lowNotification = new lowNotification();
            LoadFormInPanel(lowNotification);
        }

        private void LoadFormInPanel(Form frm)
        {
            panel1.Controls.Clear(); // إزالة أي محتويات سابقة في الـ Panel
            frm.TopLevel = false; // لمنع النموذج من أن يكون نافذة علوية
            frm.FormBorderStyle = FormBorderStyle.None; // إخفاء حواف النموذج
            frm.Dock = DockStyle.Fill; // تمديد النموذج لملء الـ Panel
            panel1.Controls.Add(frm); // إضافة النموذج إلى الـ Panel
            frm.Show(); // عرض النمو
        }
    }
}
