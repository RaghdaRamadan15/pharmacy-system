using Pharm_Project;
using PharmacyManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagment
{
    public partial class add_new_product : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        // add some property to take value from supplier_invoice
        public List<add_new_product> productss;
        public string MedicineName { get; set; }
        public string CatogryName { get; set; }
        public float Sale { get; set; }
        public int NumberUnit { get; set; }
        public int Quantitys { get; set; }
        public DateTime DateExpriation { get; set; }
        //public int supplier { get; set; }
        //public int supplier_value_id { get; set; }
        public add_new_product()
        {
            InitializeComponent();




        }



        #region display product in data gride
        //add data of product in data gride view from list by add data in it in Supplier_Invoic
        private void add_products()
        {
            foreach (var item in productss)
            {
                int indexrow = dataGridView1.Rows.Add();
                //return row exist
                DataGridViewRow row = dataGridView1.Rows[indexrow];
                //add data in cell of row
                row.Cells[0].Value = item.MedicineName;
                row.Cells[1].Value = item.CatogryName;
                row.Cells[2].Value = item.Sale.ToString();
                row.Cells[3].Value = item.NumberUnit.ToString();
                row.Cells[4].Value = item.Quantitys.ToString();
                row.Cells[5].Value = item.DateExpriation.ToShortDateString();
            }



            #region 1

            //int indexrow = dataGridView1.Rows.Add();
            // //return row exist
            ////return row exist
            //DataGridViewRow row = dataGridView1.Rows[indexrow];
            //    //add data in cell of row
            //    row.Cells[0].Value = MedicineName;
            //    row.Cells[1].Value = CatogryName;
            //    row.Cells[2].Value = Sale.ToString();
            //    row.Cells[3].Value = NumberUnit.ToString();
            //    row.Cells[4].Value = Quantitys.ToString();
            //    row.Cells[5].Value = DateExpriation.ToShortDateString();
            #endregion

        }
        #endregion



        #region load date when load page for data gride
        private void add_new_product_Load(object sender, EventArgs e)
        {

            add_products();
        }
        #endregion


        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void add_product_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int supplier_id;
                int prouduct_id;
                try
                {
                    Product prod = new Product();
                    if (row.IsNewRow) continue;
                    string pro_name = row.Cells[0].Value.ToString();
                    //frist if add new product or exist product
                    var name = context.Products.FirstOrDefault(p => p.Product_Name == pro_name);
                    if (name == null)
                    {

                        prod.Product_Name = pro_name;
                        //catogray
                        string catogray = row.Cells[1].Value.ToString();
                        int id = context.Categories.Where(c => c.Category_Name == catogray).Select(c => c.CategoryID).FirstOrDefault();
                        if (id > 0)
                        {
                            prod.Category_ID = id;
                        }
                        if (row.Cells[2].Value != null && float.TryParse(row.Cells[2].Value.ToString(), out float price))
                        { prod.Price = price; }
                        if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int unit))
                        {
                            prod.Unit = unit;
                        }
                        if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out int pack_num))
                        {
                            prod.Total_Quantity = pack_num;
                        }
                        if (prod.Unit > 0)
                        {
                            prod.Price_Per_Unit = (prod.Price / prod.Unit);

                        }
                        //add  row in table Products 

                        context.Products.Add(prod);
                        context.SaveChanges();
                        prouduct_id = prod.Product_ID;
                        var Supplier_Invoice = context.Supplier_Invoices.OrderByDescending(si => si.Supplier_Invoices_ID).FirstOrDefault();
                        supplier_id = (int)Supplier_Invoice.Suppliers_ID;
                        //add table Quantity_Details
                        Quantity_Details quantity_Detail = new Quantity_Details();

                        if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out int pack_num1))
                        {
                            quantity_Detail.Quantity = pack_num1;
                        }
                        if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime date))
                        {
                            quantity_Detail.Expiration_Date = date;
                        }
                        string name_product = row.Cells[0].Value.ToString();
                        //var p_id = context.Products.Where(p => p.Product_Name == name_product).Select(p => p.Product_ID).FirstOrDefault();
                        quantity_Detail.Product_ID = prod.Product_ID;
                        context.Quantity_Details.Add(quantity_Detail);
                        context.SaveChanges();
                        
                    }
                    else
                    {
                        Quantity_Details quantity_Detail = new Quantity_Details();
                        var name_p = context.Products.FirstOrDefault(p => p.Product_Name == pro_name);
                        if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out int pack_num1))
                        {
                            quantity_Detail.Quantity = pack_num1;
                            name_p.Total_Quantity += pack_num1;
                        }
                        if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime date))
                        {
                            quantity_Detail.Expiration_Date = date;
                        }
                        if (row.Cells[2].Value != null && float.TryParse(row.Cells[2].Value.ToString(), out float price))
                        { name_p.Price = price; }

                        if (name_p.Unit > 0)
                        {
                            name_p.Price_Per_Unit = (name_p.Price / name_p.Unit);

                        }


                        quantity_Detail.Product_ID = name_p.Product_ID;
                        context.Quantity_Details.Add(quantity_Detail);
                        context.SaveChanges();
                        prouduct_id = name_p.Product_ID;
                        var Supplier_Invoice = context.Supplier_Invoices.OrderByDescending(si => si.Supplier_Invoices_ID).FirstOrDefault();
                        supplier_id = (int)Supplier_Invoice.Suppliers_ID;
                       
                    }


                    Supplier_Invoices_Products s_I_P = new Supplier_Invoices_Products();
                    s_I_P.Product_ID = prouduct_id;
                    s_I_P.Supplier_ID = supplier_id;
                    var s_I = context.Supplier_Invoices.OrderByDescending(si => si.Supplier_Invoices_ID).FirstOrDefault();

                    s_I_P.Supplier_Invoices_ID = s_I.Supplier_Invoices_ID;

                    context.Supplier_Invoices_Products.Add(s_I_P);
                    context.SaveChanges();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($" please enter vaild data{ex.Message}");

                }
               

            }

            MessageBox.Show("Product has been added successfully in stock");

        }
    }
}
