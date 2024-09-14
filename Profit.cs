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
    public partial class Profit : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        public Profit()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerstart.Value.Date;
            DateTime endDate = dateTimePickerend.Value.Date;

            var salesquary = (from sales in context.Orders
                              where sales.Sell_date >= startDate && sales.Sell_date <= endDate
                              select sales.Total_price).Sum();
            salestxt.Text = salesquary.ToString();

            var R_customerQuery = (from rcustm in context.Customers_Returns
                                   where rcustm.return_Date >= startDate && rcustm.return_Date <= endDate
                                   select rcustm.Total_Price).Sum();
            Rcustomertxt.Text = R_customerQuery.ToString();

            var purchasequery = (from purchase in context.Supplier_Invoices
                                 where purchase.S_Invoice_Date >= startDate && purchase.S_Invoice_Date <= endDate
                                 select purchase.S_Invoice_TotalAmount).Sum();
            purchasetxt.Text = purchasequery.ToString();

            var R_supplierQuere = (from rsup in context.Return_Supplier_Invoices
                              where rsup.Return_Supplier_Date >= startDate && rsup.Return_Supplier_Date <= endDate
                              select rsup.Return_Price).Sum();
            rsuppliertxt.Text = R_supplierQuere.ToString();

            int months = ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month;
            if (endDate.Day < startDate.Day)
            {
                months--;
            }
            float salaryquery =(float) ((from emp in context.Employees
                               where emp.Hire_Date >= startDate && emp.Hire_Date <= endDate
                               select emp.Salary).Sum() ?? 0);
            float totalsalary = salaryquery * months;
            empsalarytxt.Text = totalsalary.ToString();

            var totalRevenue = salesquary - R_customerQuery;
            revenuetxt.Text = totalRevenue.ToString();

            int Maintenance = 0;
            bool isMaintenanceCostValid = int.TryParse(Maintenancecosttxt.Text, out Maintenance);
            var totalCost = purchasequery + salaryquery + Maintenance - R_supplierQuere;
            totalcosttxt.Text = totalCost.ToString();

            var netprofit = totalRevenue - totalCost;
            netprofittxt.Text = netprofit.ToString();

            var rateprofit = (netprofit / totalRevenue) * 100;
            double roundedRateProfit = Math.Round((double)rateprofit, 2);
            ratetxt.Text = $"{roundedRateProfit} %";
        }
    }
}
