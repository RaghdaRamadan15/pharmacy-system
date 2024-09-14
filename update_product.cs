using Pharm_Project;
using PharmacyManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class update_product : Form
    {
        //object of producet to save product of search
        Product product;
        string product_name;
        Pharmacy2Entities context;
        public update_product()
        {
            InitializeComponent();
            context = new Pharmacy2Entities();

        }
        //to get product from name.
        private void Search_button_Click(object sender, EventArgs e)
        {
            product = context.Products.FirstOrDefault(p => p.Product_Name == product_name);
            if (product == null)
            {
                MessageBox.Show("Please enter a valid product name.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_medicine.Text = string.Empty;

            }
            else
            {
                string prices = product.Price.ToString();
                string total = product.Total_Quantity.ToString();
                string name = product.Product_Name;
                string[] value = { name, prices, total };
                dataGridView1.Rows.Add(value);
            }
        }

       

        private void button_update_Click(object sender, EventArgs e)
        {
            product.Product_Name = dataGridView1.Rows[0].Cells[0].Value.ToString();
            float prices;
            //bool seccuss = float.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out prices);
            if(!float.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out prices)|| prices <= 0)
            {
                MessageBox.Show("plaease enter viald price");
                return;
            }
            product.Price = prices;
            if(!int.TryParse(dataGridView1.Rows[0].Cells[2].Value.ToString(), out int totall)|| totall <= 0)
            {
                MessageBox.Show("plaease enter viald quantity");
                return;
            }
            product.Total_Quantity = totall;
            context.SaveChanges();
            MessageBox.Show("Product has been update successfully.");

            //if (seccuss)
            //{
            //    product.Price = prices;
            //}
            //bool seccuss1 = int.TryParse(dataGridView1.Rows[0].Cells[2].Value.ToString(), out int totall);
            //if (seccuss1)
            //{
            //    product.Total_Quantity = totall;
            //}
            //if (seccuss1 && seccuss)
            //{
            //    context.SaveChanges();
            //    MessageBox.Show("Product has been update successfully.");
            //}
            //else { MessageBox.Show("plaease enter viald date"); }



        }

        private void text_medicine_TextChanged(object sender, EventArgs e)
        {
            product_name = text_medicine.Text;

        }
    }
}
