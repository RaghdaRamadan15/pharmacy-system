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
    public partial class Return_Supplierses : Form
    {

        Pharmacy2Entities context = new Pharmacy2Entities();
        int Invoice_Code;
        string costomerName;
        int quantity;
        float money = 0f;
        int Employee_ID;
        DateTime date_return;
        int supplier_invoice_ID;
        int supplier_id;
        int product_id;
        int cod_number;
        int total_A = 0;
        string notes;
        List<Product> p = new List<Product>();
        public Return_Supplierses()
        {
            InitializeComponent();
            employee_name.DisplayMember = "Employee_Name";
            employee_name.ValueMember = "Employee_ID";
            employee_name.DataSource = context.Employees.Select(e => e).ToList();
            total_price.Text = money.ToString("f2");
            total.Text = total_A.ToString();
            #region code
            var lastInvoice = context.Return_Supplier_Invoices
                           .OrderByDescending(inv => inv.RS_Code)
                           .FirstOrDefault();

            if (lastInvoice != null)
            {
                cod_number = int.Parse(lastInvoice.RS_Code) + 1;
            }
            else
            {
                cod_number = 1;
            }
            code_number.Text = cod_number.ToString();
            #endregion
        }





        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = context.Products
                          .Where(p => p.Product_Name == mediciene.Text)
                          .FirstOrDefault();

                var s_I = context.Supplier_Invoices
                            .Where(s => s.S_Invoice_code == Invoice_Code)
                            .FirstOrDefault();

                if (product != null && s_I != null)
                {
                    supplier_invoice_ID = s_I.Supplier_Invoices_ID;
                    supplier_id = (int)s_I.Suppliers_ID;
                    product_id = product.Product_ID;

                    var supplier_prodct = context.Supplier_Invoices_Products
                        .Where(p => p.Supplier_Invoices_ID == supplier_invoice_ID && p.Product_ID == product.Product_ID)
                        .FirstOrDefault();

                    if (supplier_prodct != null)
                    {
                        if (!int.TryParse(quentity.Text, out int quant) || quant<=0)
                        {
                            MessageBox.Show("please enter a valid position number");
                            return;
                        }

                        notes = note.Text;
                        quantity = quant;
                        total_A += quantity;
                        money += quantity * ((float)product.Price / 1.10f);

                        if (product.Total_Quantity < quantity)
                        {
                            MessageBox.Show("Cannot return this quantity because stock quantity is less.");
                            return;
                        }

                        product.Total_Quantity -= quantity;
                        p.Add(product);
                        context.SaveChanges();

                        MessageBox.Show("Added successfully!");
                        mediciene.Text = string.Empty;
                        quentity.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct invoice code and product name.");
                    }
                }
                else
                {
                    if (s_I == null)
                        MessageBox.Show("Please enter the correct invoice code.");
                    else
                        MessageBox.Show("Please enter the correct product name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try

            {
                if (date_return == DateTime.MinValue)
                {
                    date_return = DateTime.Now;
                }
                

                if (date_return.Date != DateTime.Today)
                {
                    MessageBox.Show("Purchase date must be today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Employee_ID <= 0)
                {
                    MessageBox.Show("Please select a valid Employee.");
                    return;
                }
                if (Invoice_Code < 0)
                {
                    MessageBox.Show("Please enter a valid invoice code.");
                    return;
                }

                Return_Supplier_Invoices return_Supplier_Invoices = new Return_Supplier_Invoices
                {
                    Supplier_Note = notes,
                    Return_Supplier_Date = date_return,
                    Return_Price = money,
                    Return_Total_Amount = total_A,
                    RS_Code = cod_number.ToString(),
                    Employee_ID = Employee_ID
                };

                context.Return_Supplier_Invoices.Add(return_Supplier_Invoices);
                context.SaveChanges();

                MessageBox.Show("Billing added successfully!");

                foreach (var item in p)
                {
                    Return_Supplier_Invoices_Products r_s_p = new Return_Supplier_Invoices_Products
                    {
                        Product_ID = item.Product_ID,
                        Return_Supplier_ID = return_Supplier_Invoices.Return_Supplier_ID,
                        Supplier_Invoices_ID = supplier_invoice_ID,
                        Supplier_ID = supplier_id
                    };

                    context.Return_Supplier_Invoices_Products.Add(r_s_p);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }







        private void employee_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_ID = int.Parse(employee_name.SelectedValue.ToString());
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (date.Value != DateTime.MinValue)
            {
                date_return = date.Value;
            }
            else
            {
                date_return = DateTime.Now;
            }
        }



        private void inv_code_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inv_code.Text, out int c))
            {
                Invoice_Code = c;
            }
            else
            {
                MessageBox.Show("please enter the code of his purchases invoice is correct ");
            }
        }
    }
}
