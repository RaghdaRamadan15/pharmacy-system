using Pharm_Project;
using PharmacyManagment;
using System;
using System.Data.Entity;
using System.Linq;
namespace Pharm_Project
{
    public class ExpirationChecker
    {
        //timer to run for 24h
        private System.Threading.Timer timer;

        public ExpirationChecker()
        {
            try
            {
                //repeat fun for 5 h
                timer = new System.Threading.Timer(CheckExpirations, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Initialization Error: {ex.Message}");
            }
        }

        private void CheckExpirations(object state)
        {
            try
            {
                //create new context for each call function
                using (var context = new Pharmacy2Entities())
                {
                    int daysBeforeExpiration = 30;
                    //return all product will end after 30 day
                    var expiringMedicines = context.Quantity_Details
                        .Where(p => DbFunctions.DiffDays(DateTime.Today, p.Expiration_Date) == daysBeforeExpiration)
                        .ToList();

                    foreach (var item in expiringMedicines)
                    {
                        var existingRecord = context.ExpiringMedicines.FirstOrDefault(
                            e => e.MedicineId == item.Product_ID);

                        if (existingRecord == null)
                        {
                            var product = context.Products.FirstOrDefault(p => p.Product_ID == item.Product_ID);
                            if (product != null)
                            {
                                var expiringMedicine = new ExpiringMedicine
                                {
                                    ExpirationDate = item.Expiration_Date,
                                    MedicineId = item.Product_ID,
                                    MedicineName = product.Product_Name
                                };
                                //add obj in ExpiringMedicines
                                context.ExpiringMedicines.Add(expiringMedicine);
                                //context.SaveChanges();
                            }

                        }
                    }
                    //reture obj that date of today more then date  ExpirationDate in table ExpiringMedicines
                    var expiredRecords = context.ExpiringMedicines
                        .ToList();

                    foreach (var record in expiredRecords)

                    {
                        //var product = context.Quantity_Details.FirstOrDefault(p => p.Expiration_Date == record.ExpirationDate);

                        var product = context.Return_Supplier_Invoices_Products.FirstOrDefault(p => p.Product_ID == record.MedicineId);
                        if (product != null)
                        {

                            context.ExpiringMedicines.Remove(record);

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
    }
}