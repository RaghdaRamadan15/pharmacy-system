using Pharm_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class Supplier_Invoic : Form
    {
        #region property
        List<add_new_product> productes = new List<add_new_product>();
        int Employee_ID;
        int Supplier_ID;
        int code;
        float totol_money = 0f;
        public DateTime date_Expriation { get; set; }
        public string Medicine_name { get; set; }
        public string catogry_name { get; set; }
        public int catogry_Id { get; set; }
        public int quantitys { get; set; }
        public int number_unit { get; set; }
        public float sale { get; set; }
        public float buy { get; set; }

        DateTime date_purchuses;
        Pharmacy2Entities context;

        #endregion

        public Supplier_Invoic()
        {
            InitializeComponent();
            context = new Pharmacy2Entities();
            total.Text = totol_money.ToString("f2");

            #region combobox_to_Supplier
            com_supplier_name.DisplayMember = "Supplier_Name";
            com_supplier_name.ValueMember = "Supplier_ID";
            com_supplier_name.DataSource = context.Suppliers.Select(s => s).ToList();
            #endregion

            #region combobox to Employee
            comboBox2.DisplayMember = "Employee_Name";
            comboBox2.ValueMember = "Employee_ID";
            comboBox2.DataSource = context.Employees.Select(e => e).ToList();
            #endregion

            #region combobox to Category
            Catogray.DisplayMember = "Category_Name";
            Catogray.ValueMember = "CategoryID";
            Catogray.DataSource = context.Categories.Select(e => e).ToList();
            #endregion
            #region code
            var lastInvoice = context.Supplier_Invoices
                           .OrderByDescending(inv => inv.S_Invoice_code)
                           .FirstOrDefault();

            if (lastInvoice != null)
            {
                code = (int)lastInvoice.S_Invoice_code + 1;
            }
            else
            {
                code = 1;
            }
            code_bill.Text = code.ToString();

            #endregion

        }
        #region save supplier invoices in database and go display product
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region add obj from Supplier_Invoices in database
            //add supplier in date base
            if (date_purchuses == DateTime.MinValue)
            {
                date_purchuses = DateTime.Now;
            }

            if (date_purchuses.Date != DateTime.Today)
            {
                MessageBox.Show("Purchase date must be today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Supplier_ID <= 0)
            {
                MessageBox.Show("Please select a valid Supplier.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Employee_ID <= 0)
            {
                MessageBox.Show("Please select a valid Employee.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (code <= 0)
            {
                MessageBox.Show("Please enter a valid code for the Bill.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier_Invoices supplier_Inv = new Supplier_Invoices();
            supplier_Inv.S_Invoice_TotalAmount = totol_money;
            supplier_Inv.S_Invoice_Date = date_purchuses;
            supplier_Inv.S_Invoice_code = code;
            supplier_Inv.Suppliers_ID = Supplier_ID;
            supplier_Inv.Employee_ID = Employee_ID;
            context.Supplier_Invoices.Add(supplier_Inv);
            context.SaveChanges();
            MessageBox.Show("Billing added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion

            #region go view page product
            add_new_product add_New_Product1 = new add_new_product();
            add_New_Product1.productss = productes;
            add_New_Product1.Show();
            #endregion
        }
        #endregion

        #region supplier_name
        private void com_supplier_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier_ID = int.Parse(com_supplier_name.SelectedValue.ToString());
        }
        #endregion

        #region Employee_name
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_ID = int.Parse(comboBox2.SelectedValue.ToString());
        }
        #endregion

        #region date_purchuse
        private void date_purchuse_ValueChanged(object sender, EventArgs e)
        {
            date_purchuses = date_purchuse.Value;

            if (date_purchuses.Date != DateTime.Today)
            {
                MessageBox.Show("Purchase date must be today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_purchuse.Focus();
                return;
            }
        }
        #endregion

        #region get name category and id
        private void Catogray_SelectedIndexChanged(object sender, EventArgs e)
        {
            catogry_name = Catogray.SelectedItem.ToString();
            catogry_Id = int.Parse(Catogray.SelectedValue.ToString());
        }
        #endregion

        #region date_ExpirationDate
        private void date_ExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            date_Expriation = date_ExpirationDate.Value;

            if (date_Expriation < DateTime.Today)
            {
                MessageBox.Show("Expiration date cannot be earlier than today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_ExpirationDate.Focus();
                return;
            }
        }
        #endregion

        #region take data product from box
        private void add_products()
        {
            Medicine_name = nameproducttxt.Text;
            if (string.IsNullOrEmpty(Medicine_name))
            {
                MessageBox.Show("Please enter a valid Medicine name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(catogry_name))
            {
                MessageBox.Show("Please select a valid Category.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberUnit;
            bool success = int.TryParse(Number_unit.Text, out numberUnit);
            if (!success || numberUnit <= 0)
            {
                MessageBox.Show("Please enter a valid number for the Number of Units (greater than 0).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            number_unit = numberUnit;

            int quant;
            bool success2 = int.TryParse(quantity.Text, out quant);
            if (!success2 || quant <= 0)
            {
                MessageBox.Show("Please enter a valid number for the Quantity (greater than 0).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            quantitys = quant;

            float bill;
            bool success3 = float.TryParse(pricebuy.Text, out bill);
            if (!success3 || bill <= 0)
            {
                MessageBox.Show("Please enter a valid number for the Buy Price (greater than 0).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buy = bill;

            pricesale.Text = (buy * 1.10).ToString("f2");
            sale = float.Parse(pricesale.Text);
            totol_money += (buy * quantitys);
            total.Text = totol_money.ToString();

            if (date_Expriation < DateTime.Today)
            {
                MessageBox.Show("Expiration date cannot be earlier than today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            add_new_product new_product = new add_new_product
            {
                MedicineName = Medicine_name,
                CatogryName = catogry_name,
                Sale = sale,
                NumberUnit = number_unit,
                Quantitys = quantitys,
                DateExpriation = date_Expriation,
            };

            bool productExists = false;
            for (int i = 0; i < productes.Count; i++)
            {
                if (productes[i].MedicineName == new_product.MedicineName)
                {
                    productExists = true;
                    MessageBox.Show($"The product {new_product.MedicineName} has already been added to this Bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }

            if (!productExists)
            {
                productes.Add(new_product);
            }

            int indexrow = dgvcart.Rows.Add();
            DataGridViewRow row = dgvcart.Rows[indexrow];
            row.Cells[0].Value = new_product.MedicineName;
            row.Cells[1].Value = new_product.Quantitys;
            row.Cells[2].Value = (buy * new_product.Quantitys).ToString("f2");

            #region clear box
            string[] textBoxNames = { "pricesale", "pricebuy", "quantity", "Number_unit", "nameproducttxt" };

            foreach (string textBoxName in textBoxNames)
            {
                TextBox textBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Text = string.Empty;
                }
            }
            #endregion
        }
        #endregion

        private void addcartBtn_Click(object sender, EventArgs e)
        {
            add_products();
        }
    }
}
