
using Pharm_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagment
{
    public partial class Supplierses : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        public Supplierses()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            TxtName.Text = "";
            TxtPhone.Text = "";
            TxtAddress.Text = "";
            TxtEmail.Text = "";
        }

        private void RefreshDataGridView()
        {
            dgvsuppliers.Rows.Clear();

            var sup = context.Suppliers.Select(s=>s).ToList();
            foreach (var item in sup) {
                int index = dgvsuppliers.Rows.Add();
                DataGridViewRow row = dgvsuppliers.Rows[index];
                row.Cells[0].Value = item.Supplier_Name;
                row.Cells[1].Value = item.Supplier_Phone;
                row.Cells[2].Value = item.Supplier_Email;
                row.Cells[3].Value = item.Supplier_Address;

                row.Tag= item;
                

            }
           
            
        }
        private void Supplierses_Load_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                

                    Supplier existingSupplier = context.Suppliers.FirstOrDefault(s =>
                        s.Supplier_Name == TxtName.Text.ToString() &&
                        s.Supplier_Phone == TxtPhone.Text.ToString() &&
                        s.Supplier_Email == TxtEmail.Text.ToString());

                    if (existingSupplier != null)
                    {
                        MessageBox.Show("This supplier already exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // إضافة المورد الجديد
                    Supplier newSupplier = new Supplier
                    {
                        Supplier_Name = TxtName.Text.ToString(),
                        Supplier_Phone = TxtPhone.Text.ToString(),
                        Supplier_Address = TxtAddress.Text.ToString(),
                        Supplier_Email = TxtEmail.Text.ToString()
                    };

                    context.Suppliers.Add(newSupplier);
                    context.SaveChanges();

                    ClearText();
                    RefreshDataGridView();

                    MessageBox.Show("New Supplier Is Inserted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("please enter all datials for create new  supplier  " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvsuppliers.Rows)
                {
                    var supplierToUpdate = row.Tag as Supplier;

                    if (supplierToUpdate != null)
                    {

                        supplierToUpdate.Supplier_Name = row.Cells[0].Value.ToString();
                        supplierToUpdate.Supplier_Phone = row.Cells[1].Value.ToString();
                        supplierToUpdate.Supplier_Address = row.Cells[2].Value.ToString();
                        supplierToUpdate.Supplier_Email = row.Cells[3].Value.ToString();

                    }
                }
                ClearText();
                RefreshDataGridView();

                MessageBox.Show("Supplier Information Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_Address_Click(object sender, EventArgs e)
        {

        }

        private void label_Email_Click(object sender, EventArgs e)
        {

        }

        private void label_Phone_Click(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

       
    }
}