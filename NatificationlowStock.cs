using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharm_Project
{
    public partial class NatificationlowStock : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        private void InitializeNotifications()
        {
            var lowStockMedicines = context.Products
                .Where(p => p.Total_Quantity < 4)
                .ToList();

            foreach (var item in lowStockMedicines)
            {
                Label label = new Label();
                //Button button = new Button();

                //button.Text = "Confirm";
                //button.Size = new Size(100, 30);
                //button.Font = new Font("Arial", 12, FontStyle.Regular);
                //button.BackColor = Color.FromArgb(0, 64, 64);
                //button.ForeColor = Color.White;
                //button.FlatStyle = FlatStyle.Flat;
                //button.FlatAppearance.BorderSize = 0;
                //button.Margin = new Padding(10, 5, 5, 10);
                //button.Click += (sender, e) => Button_Click(sender, e, item, label, button);

                label.Text = $"Warning: The product {item.Product_Name} has only {item.Total_Quantity} units left.";
                label.AutoSize = true;
                label.Font = new Font("Arial", 14, FontStyle.Regular);
                label.ForeColor = Color.LightCoral;
                label.Margin = new Padding(0, 10, 0, 10);

                panellowStock.Controls.Add(label);
               // panellowStock.Controls.Add(button);
            }
        }

        //private void Button_Click(object sender, EventArgs e, Product item, Label label, Button button)
        //{
        //    context.Products.Remove(item);
        //    context.SaveChanges();

        //    label.Visible = false;
        //    button.Visible = false;
        //}


    }
}
