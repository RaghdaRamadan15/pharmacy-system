using Pharm_Project;
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
    public partial class Categoryies : Form
    {
        string cat_name;
        string cat_description;
        Pharmacy2Entities context;
        public Categoryies()
        {
            InitializeComponent();
            //create obj from dbcontext
            context = new Pharmacy2Entities();
        }
        #region take category name
        //take category name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cat_name = textBox1.Text;
        }
        #endregion

        #region description_from_textbox
        //take description
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cat_description = textBox2.Text;
        }
        #endregion

        #region add new category
        //to add new category in database
        private void Add_category_Click(object sender, EventArgs e)
        {

            Category category = new Category();
            if ((cat_name != null) && (cat_description != null))
            {
                var cot=context.Categories.FirstOrDefault(c => c.Category_Name == cat_name);
                if (cot == null) {
                    category.Category_Name = cat_name;
                    category.Description = cat_description;
                    context.Categories.Add(category);
                    context.SaveChanges();
                    MessageBox.Show("Added Successfully  ", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("catogray is already added before   ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("you should enter name for new category and Description  ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Text = " ";
            textBox1.Text = "";

        }
        #endregion


        #region show catogories
        //to display all catogory
        private void ShoeBtn_Click(object sender, EventArgs e)
        {
            dgvcart.Rows.Clear();
            var catogories = context.Categories.Select(c => c).ToList();
            if (catogories.Count == 0)
            {
                MessageBox.Show("you should Add category in first  ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                foreach (var item in catogories)
                {
                    // to add value in array to add it as row bacouse it
                    // each value in index add it as value to cell in row
                    string[] row = new string[]
                        {
                                item.Category_Name,
                                item.Description
                        };
                    dgvcart.Rows.Add(row);
                }
            }


        }


        #endregion

       
    }
}
