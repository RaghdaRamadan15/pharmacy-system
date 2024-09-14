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
    public partial class Show_All_Invoices : Form
    {


        Pharmacy2Entities context = new Pharmacy2Entities();
        public Show_All_Invoices()
        {
            InitializeComponent();
            comboBoxInvoices.Items.Add("Sell Invoices");
            comboBoxInvoices.Items.Add("Supplier Invoices");
            comboBoxInvoices.Items.Add("Return Supplier Invoices");
            comboBoxInvoices.Items.Add("Return Customer Invoices"); 
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxInvoices.SelectedItem == null)
            {
                MessageBox.Show("Please select an invoice type.");
                return;
            }
            string selectedInvoicesType = comboBoxInvoices.SelectedItem.ToString();
            DateTime startDate = dateTimePickerstart.Value.Date; 
            DateTime endDate = dateTimePickerend.Value.Date;  
            IQueryable<object> query = null;
            switch (selectedInvoicesType)
            {
                case "Sell Invoices":
                     query = from o in context.Orders
                                join emp in context.Employees on o.Employee_ID equals emp.Employee_ID
                                join po in context.Products_Orders on o.Order_ID equals po.Order_ID
                                join p in context.Products on po.Product_ID equals p.Product_ID
                                where o.Sell_date >= startDate && o.Sell_date <= endDate
                                select new
                                {
                                    o.Order_Code,
                                    p.Product_Name,
                                    po.Quantity,
                                    p.Price,
                                    o.Sell_date,
                                    emp.Employee_Name,
                                    o.Customer_Name,
                                    o.Customer_Phone
                                };
                    break;
                case "Supplier Invoices":
                     query = from si in context.Supplier_Invoices
                                join emp in context.Employees on si.Employee_ID equals emp.Employee_ID
                                join sip in context.Supplier_Invoices_Products on si.Supplier_Invoices_ID equals sip.Supplier_Invoices_ID
                                join p in context.Products on sip.Product_ID equals p.Product_ID
                                join s in context.Suppliers on si.Suppliers_ID equals s.Supplier_ID
                                where si.S_Invoice_Date >= startDate && si.S_Invoice_Date <= endDate
                                select new
                                {
                                    InvoiceCode = si.S_Invoice_code,
                                    ProductName = p.Product_Name,
                                    //InvoiceTotalAmount = si.S_Invoice_TotalAmount,
                                    InvoiceDate = si.S_Invoice_Date,
                                    SupplierName = s.Supplier_Name,
                                    EmployeeName=emp.Employee_Name
                                };
                    break;
                case "Return Supplier Invoices":
                     query = from rsi in context.Return_Supplier_Invoices
                            join rsip in context.Return_Supplier_Invoices_Products on rsi.Return_Supplier_ID equals rsip.Return_Supplier_ID
                            join p in context.Products on rsip.Product_ID equals p.Product_ID
                            join s in context.Suppliers on rsip.Supplier_ID equals s.Supplier_ID
                            join emp in context.Employees on rsi.Employee_ID equals emp.Employee_ID
                            join si in context.Supplier_Invoices on rsip.Supplier_Invoices_ID equals si.Supplier_Invoices_ID
                             where rsi.Return_Supplier_Date>=startDate&&rsi.Return_Supplier_Date<=endDate
                             select new
                            {
                                RSCode = rsi.RS_Code,
                                ProductName = p.Product_Name,
                                SInvoiceCode = si.S_Invoice_code,
                                ReturnTotalAmount = rsi.Return_Total_Amount,
                                ReturnPrice = rsi.Return_Price,
                                ReturnSupplierDate = rsi.Return_Supplier_Date,
                                SupplierName = s.Supplier_Name,
                                EmployeeName = emp.Employee_Name
                            };
                    break;
                case "Return Customer Invoices":
                     query = from cro in context.Customers_Returns_Orders
                                join cr in context.Customers_Returns on cro.Cust_Return_ID equals cr.Cust_Return_ID
                                join p in context.Products on cro.Product_ID equals p.Product_ID
                                join o in context.Orders on cro.Order_ID equals o.Order_ID
                                join emp in context.Employees on cro.Employee_Id equals emp.Employee_ID
                                where cr.return_Date>=startDate&& cr.return_Date<=endDate
                               select new
                                {
                                    ReturnCode = cr.c_Return_Code,
                                    ProductName = p.Product_Name,
                                    OrderCode = o.Order_Code,
                                    TotalAmount = cr.Total_amount,
                                    TotalPrice = cr.Total_Price,
                                    ReturnDate = cr.return_Date,
                                    EmployeeName = emp.Employee_Name,
                                    CustomerName = cr.Customer_Name
                                };
                    break;
                default:
                    MessageBox.Show("Unknown invoice type selected.");
                    return;
            }
            dgv_showInvoices.DataSource = query.ToList();
        }

    }
}
