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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagment
{
    public partial class Sell_Medicine : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        int cod_number;
        int Employee_ID;
        public Sell_Medicine()
        {
            InitializeComponent();
            quantitytxtbox.TextChanged += new EventHandler(totalpricetxt_TextChanged);
            pricetxt.TextChanged += new EventHandler(totalpricetxt_TextChanged);
            dgvcart.RowsAdded += dgvcart_RowsAdded;
            dgvcart.CellValueChanged += dgvcart_CellValueChanged;
            #region code
            var lastInvoice = context.Orders
                           .OrderByDescending(inv => inv.Order_Code)
                           .FirstOrDefault();

            if (lastInvoice != null)
            {
                cod_number = int.Parse(lastInvoice.Order_Code )+ 1;
            }
            else
            {
                cod_number = 1;
            }
            invoicecodetxt.Text = cod_number.ToString();

            #endregion

            #region combobox to Employee
            comboBoxempname.DisplayMember = "Employee_Name";
            comboBoxempname.ValueMember = "Employee_ID";
            comboBoxempname.DataSource = context.Employees.Select(e => e).ToList();
            #endregion
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var serachQuery = searchtxt.Text.ToLower();
            if (string.IsNullOrEmpty(serachQuery))
            {
                MessageBox.Show("Enter Medicine Name. ");
            }
            else
            {
                //p.Product_ID, 
                var filterProduct = context.Products.Select(p => new { p.Product_Name, p.Unit, p.Price_Per_Unit, p.Total_Quantity, p.Price })
                                                    .Where(d => d.Product_Name.ToLower().Contains(serachQuery)).ToList();
                dgvsearch.DataSource = filterProduct;
            }
        }

        private void dgvsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsearch != null)
            {
                //noproducttxt.Text = dgvsearch.CurrentRow.Cells[0].Value.ToString();
                nameproducttxt.Text = dgvsearch.CurrentRow.Cells[0].Value.ToString();
                noofunitstxt.Text = dgvsearch.CurrentRow.Cells[1].Value.ToString();
                priceperunittxt.Text = dgvsearch.CurrentRow.Cells[2].Value.ToString();
                pricetxt.Text = dgvsearch.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void totalpricetxt_TextChanged(object sender, EventArgs e)
        {
            if(float.TryParse(quantitytxtbox.Text,out float num1)&& float.TryParse(pricetxt.Text,out float num2))
            {
                float result = num1 * num2;
                totalpricetxt.Text = result.ToString("f2");
            }
        }

        private void addcartBtn_Click(object sender, EventArgs e)
        {
            //string noproduct = noproducttxt.Text;
            string name = nameproducttxt.Text;
            string quentity = quantitytxtbox.Text;
            string totalprice = totalpricetxt.Text;
            dgvcart.Rows.Add(name, quentity, totalprice);
        }

       
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            //if(dgvcart.Rows.Count==0 || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(customernametxt.Text))
            //{
            //    MessageBox.Show("enter all data");
            //}
            int totalquantity = 0;
            double totalprice = 0;
            foreach(DataGridViewRow row in dgvcart.Rows)
            {
                if (row.IsNewRow) continue;
                totalquantity += Convert.ToInt32(row.Cells[1].Value);
                totalprice += Convert.ToDouble(row.Cells[2].Value);
            }
            var employee = context.Employees.FirstOrDefault(emp => emp.Employee_Name == comboBoxempname.Text);
            var order = new Order
            {
                Total_Amount = totalquantity,
                Total_price = totalprice,
                Customer_Name = customernametxt.Text,
                Customer_Phone = customerphonetxt.Text,
                Order_Code=invoicecodetxt.Text,
                Employee_ID =  Employee_ID,
                Sell_date = dateTimePicker1.Value
            };
            context.Orders.Add(order);
            context.SaveChanges();
            int orderid = order.Order_ID;
            foreach(DataGridViewRow row1 in dgvcart.Rows)
            {
                if (row1.IsNewRow) continue;
                //int productid = Convert.ToInt32(row1.Cells[0].Value);
                //var productid =  context.Products.FirstOrDefault(prod => prod.Product_Name == row1.Cells[0].Value);
                string productName = row1.Cells[0].Value?.ToString();
                var product = context.Products.FirstOrDefault(prod => prod.Product_Name == productName);

                int quntity = Convert.ToInt32(row1.Cells[1].Value);
                if (quntity <= 0)
                {
                    MessageBox.Show($" please enter vaild Quantity ");
                    return;
                }
                var productorder = new Products_Orders
                {
                    Order_ID = orderid,
                    Product_ID = product.Product_ID,
                    Quantity = quntity
                };
                context.Products_Orders.Add(productorder);
                var product2 = context.Products.FirstOrDefault(p => p.Product_ID == product.Product_ID);
                if (product.Total_Quantity<quntity)
                {
                    MessageBox.Show($"The Required Quantity:  {quntity} More Than The Available Quantity: {product.Total_Quantity}  For The Product:  {product.Product_Name}");
                    return;
                }
                product.Total_Quantity -= quntity;
                context.SaveChanges();
            }
            MessageBox.Show("add successfully");
        }
        private void updateTotalPrice()
        {
            float totalprice = 0;
            foreach(DataGridViewRow row in dgvcart.Rows)
            {
                if (row.IsNewRow) continue;
                float price;
                if (float.TryParse(row.Cells[2].Value?.ToString(), out price))
                {
                    totalprice += price ;
                }
            }
            totalpricelbl.Text = $"Total Price is:  {totalprice:c}";
        }

        private void dgvcart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvcart.Columns[2].Index)
            {
                updateTotalPrice();
            }
        }

        private void dgvcart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateTotalPrice();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Clear();
            invoicecodetxt.Clear();
            nameproducttxt.Clear();
            noofunitstxt.Clear();
            priceperunittxt.Clear();
            pricetxt.Clear();
            quantitytxtbox.Clear();
            totalpricetxt.Clear();
            //noselltxt.Clear();
            customernametxt.Clear();
            customerphonetxt.Clear();
            dgvcart.Rows.Clear();
            //dgvsearch.Rows.Clear();
            totalpricelbl.Text = "Total Price is:  $0.00 ";
        }

        private void Sell_Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.Employees' table. You can move, or remove it, as needed.
           

        }

        private void comboBoxempname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Employee_ID = int.Parse(comboBoxempname.SelectedValue.ToString());
            
        }
    }
}
