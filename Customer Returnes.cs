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
    public partial class Customer_Returnes : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        string Invoice_Code;
        string costomerName;
        int quantity;
        int piec;
        float money = 0f;
        int Employee_ID;
        DateTime date_return;
        int order_ID;
        int product_id;
        int cod_number;
        int total_A = 0;
        List<Product> p = new List<Product>();
        public Customer_Returnes()
        {
            InitializeComponent();
            CbEmployeesName.DisplayMember = "Employee_Name";
            CbEmployeesName.ValueMember = "Employee_ID";
            CbEmployeesName.DataSource = context.Employees.Select(e => e).ToList();
            TbProPrice.Text = money.ToString();
            #region code
            var lastInvoice = context.Customers_Returns
                           .OrderByDescending(inv => inv.c_Return_Code)
                           .FirstOrDefault();

            if (lastInvoice != null)
            {
                cod_number = (int)lastInvoice.c_Return_Code + 1;
            }
            else
            {
                cod_number = 1;
            }
            code.Text = cod_number.ToString();

            #endregion
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (date_return == DateTime.MinValue)
            {
                date_return = DateTime.Now;
            }

           

            if (date_return.Date != DateTime.Today)
            {
                MessageBox.Show("Sell date must be today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Employee_ID <= 0)
            {
                MessageBox.Show("Please select a valid Employee.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Invoice_Code))
            {
                MessageBox.Show("Please enter a valid code of Bill.");
                return;
            }
            Customers_Returns customers = new Customers_Returns();

            customers.Total_Price = money;
            customers.Total_amount = total_A;
            customers.return_Date = date_return;
            customers.c_Return_Code = cod_number;
            customers.Customer_Name = costomerName;
            context.Customers_Returns.Add(customers);
            context.SaveChanges();
            MessageBox.Show("Adding Billing  success ");
            Customers_Returns_Orders c_R_O = new Customers_Returns_Orders();
            foreach (var item in p)
            {
                c_R_O.Product_ID = item.Product_ID;
                c_R_O.Order_ID = order_ID;
                c_R_O.Employee_Id = Employee_ID;

                c_R_O.Cust_Return_ID = customers.Cust_Return_ID;
                context.Customers_Returns_Orders.Add(c_R_O);
                context.SaveChanges();
            }
        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            Product product = context.Products
                      .Where(p => p.Product_Name == TbPName.Text)

                      .FirstOrDefault();

            var order = context.Orders
                        .Where(o => o.Order_Code == Invoice_Code)

                       .FirstOrDefault();


            if (product != null && order != null)
            {
                order_ID = order.Order_ID;
                product_id = product.Product_ID;
                var product_order = context.Products_Orders.Where(p => p.Order_ID == order_ID && p.Product_ID == product_id).FirstOrDefault();
                if (product_order != null)
                {
                    if (!int.TryParse(TbPQuantity.Text, out int quant) || quant<0)
                    {
                        MessageBox.Show("please enter valid number");
                        return;
                    }
                    quantity = quant;

                    if (!int.TryParse(piece.Text, out int number)|| number<0)
                    {
                        MessageBox.Show("please enter valid number to Unit");
                        return;
                    }
                    piec = number;

                    if (quantity != 0)
                    {
                        float pr = (float)product.Price;
                        money = pr * quantity;
                    }
                    else if (piec != 0)
                    {

                        money = piec * (float)product.Price_Per_Unit;

                    }
                    else
                    {
                        float pr = (float)product.Price;
                        float unit = (float)product.Price_Per_Unit;
                        money += (pr * quantity) + (unit * piec);


                    }
                    total_A += quantity;
                    TbProPrice.Text = money.ToString("f2");
                    if (quantity != 0 || piec != 0)
                    {
                        product.Total_Quantity += quantity;
                        p.Add(product);
                        context.SaveChanges();
                        MessageBox.Show("Adding successfully ");
                    }
                    else
                    {
                        MessageBox.Show("please enter quantity ");
                    }

                    TbPName.Text = string.Empty;
                    string[] textBoxNames = { "TbPQuantity", "piece" };


                    foreach (string textBoxName in textBoxNames)
                    {
                        System.Windows.Forms.TextBox textBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                        if (textBox != null)
                        {

                            textBox.Text = "0";
                        }
                    }



                }
                else
                {
                    MessageBox.Show("Please enter the correct invoice code and product name");
                }

            }
            else
            {
                if (order == null)
                    MessageBox.Show("Please enter the correct invoice code");

                else
                    MessageBox.Show("Please enter the correct product name");

            }
        }

        private void CbEmployeesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_ID = int.Parse(CbEmployeesName.SelectedValue.ToString());
        }

        private void TbCustName_TextChanged(object sender, EventArgs e)
        {
            costomerName = TbCustName.Text;
        }

        private void TbInvoice_Code_TextChanged(object sender, EventArgs e)
        {
            Invoice_Code = TbInvoice_Code.Text;
        }

        private void DtInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            if (DtInvoiceDate.Value != DateTime.MinValue)
            {
                date_return = DtInvoiceDate.Value;
            }
            else
            {

                date_return = DateTime.Now;
            }
        }

        private void TbProPrice_TextChanged(object sender, EventArgs e)
        {
            TbProPrice.Text = money.ToString("f2");
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(code.Text, out int c))
            {
                cod_number = c;
            }
            else
            {
                MessageBox.Show("please enter vaild code for bill");
            }
        }

       
    }
}
