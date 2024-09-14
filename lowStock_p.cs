using Pharm_Project;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagment
{
    public class lowStock_p
    {

        //timer to run for 24h
        private System.Threading.Timer timer;

        public lowStock_p()
        {
            try
            {
                //repeat fun for 5 h
                timer = new System.Threading.Timer(Checklow, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Initialization Error: {ex.Message}");
            }
        }

        private void Checklow(object state)
        {
            try
            {
                //create new context for each call function
                using (var context = new Pharmacy2Entities())
                {
                    int low = 3;
                    //return all product will end after 30 day
                    var lowMedicines = context.Products.Where(p => p.Total_Quantity == low)
                        .ToList();

                    foreach (var item in lowMedicines)
                    {
                        var existingRecord = context.low_stock.FirstOrDefault(
                            e => e.MedicineId == item.Product_ID);

                        if (existingRecord == null)
                        {
                            var product = context.Products.FirstOrDefault(p => p.Product_ID == item.Product_ID);
                            if (product != null)
                            {

                                var lowMedicine = new low_stock
                                {

                                    MedicineId = item.Product_ID,
                                    MedicineName = product.Product_Name
                                };
                                //add obj in ExpiringMedicines
                                context.low_stock.Add(lowMedicine);
                               
                            }

                        }
                    }

                    var product_low=context.low_stock.Select(p=>p).ToList();
                    foreach (var item in product_low)
                    {
                        var product = context.Products.FirstOrDefault(p => p.Product_ID == item.MedicineId);
                        if(product != null)
                        {
                            if (product.Total_Quantity > 3)
                            {
                                context.low_stock.Remove(item);
                            }
                        }
                    }
                    context.SaveChanges();
                }
               
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    } }
    

