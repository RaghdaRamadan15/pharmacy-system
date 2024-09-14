using Pharm_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagment
{
    public partial class DashBoard : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();
        public DashBoard()
        {
            InitializeComponent();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            timertimeDate.Start();
            UpdateEmployeeCount();
            LoadTotalProduct();
            LoadTotalDailyReturns();
            LoadTotalTodayPurchases();
            // call to function ---> calculate daily profit
            UpdateCashiertotallabel();
            // مسح العناصر الموجودة في ComboBox
            cmbSelecttype.Items.Clear();
            cmbFilter.Items.Clear();

            // تحميل الكاتيجوريز من قاعدة البيانات
            LoadCategories();

            // إضافة خيارات إلى ComboBox الثاني
            cmbFilter.Items.Add("All Products");
            cmbFilter.Items.Add("Low Stock");
            cmbFilter.Items.Add("Expiry Date");
        }
        private void UpdateCashiertotallabel()
        {

            var today = DateTime.Today;

            // حساب إجمالي المبيعات اليوم
            var totalSales = context.Orders
                            .Where(s => s.Sell_date == today)
                            .Sum(s => s.Total_price) ?? 0;

            // حساب إجمالي مرتجعات العملاء اليوم
            var totalCustomerReturns = context.Customers_Returns
                                      .Where(cr => cr.return_Date == today)
                                      .Sum(cr => cr.Total_Price) ?? 0;

            // حساب إجمالي مرتجعات الموردين اليوم
            var totalSupplierReturns = context.Return_Supplier_Invoices
                                    .Where(sr => sr.Return_Supplier_Date == today)
                                    .Sum(sr => sr.Return_Price) ?? 0;

            // حساب الربح الصافي
            var dailyProfit = totalSales - totalCustomerReturns + totalSupplierReturns;

            // عرض الربح في Label
            label2.Text = dailyProfit.ToString();
        }
        // تحديث عدد الموظفين في الـ Label
        private void UpdateEmployeeCount()
        {
            int employeeCount = context.Employees.Count();
            labelEmployeeCount.Text = employeeCount.ToString() + " Employees";
            //labelEmployeeCount.AutoSize = true; // حجم تلقائي
            //labelEmployeeCount.TextAlign = ContentAlignment.MiddleCenter; // توسيط النص
            //labelEmployeeCount.Location = new Point(
            //    (totalEmployeepanel.Width - labelEmployeeCount.Width) / 2,
            //    (totalEmployeepanel.Height - labelEmployeeCount.Height) / 2); // حساب الموقع
        }

        // عندما يمر الماوس فوق الـ Panel
        private void totalEmployeepanel_MouseHover_1(object sender, EventArgs e)
        {
            UpdateEmployeeCount();

        }
        // دالة لحذف موظف وتحديث العدد بعد الحذف
        private void DeleteEmployee(int employeeId)
        {
            var employee = context.Employees.SingleOrDefault(emp => emp.Employee_ID == employeeId);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                UpdateEmployeeCount();
            }
        }
        private void timertimeDate_Tick(object sender, EventArgs e)
        {
            // تحديث الوقت والتاريخ
            labelDateInfo.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy", new CultureInfo("en-US"));
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", new CultureInfo("en-US"));
        }
        private void LoadTotalProduct()
        {
            int totalQuantity = context.Products.Sum(p => (int?)p.Total_Quantity) ?? 0;

            labelTotalProduct.Text = totalQuantity.ToString() + " Products";
            //labelTotalProduct.AutoSize = true; // حجم تلقائي
            //labelTotalProduct.TextAlign = ContentAlignment.MiddleCenter; // توسيط النص
            //labelTotalProduct.Location = new Point(
            //    (panelTotalproduct.Width - labelTotalProduct.Width) / 2,
            //    (panelTotalproduct.Height - labelTotalProduct.Height) / 2); // حساب الموقع
        }

        private void panelTotalproduct_MouseHover_1(object sender, EventArgs e)
        {
            LoadTotalProduct();
        }

        private void LoadTotalDailyReturns()
        {
            int totalAmount = context.Customers_Returns
                .Where(r => r.return_Date == DateTime.Today)
                .Sum(r => (int?)r.Total_amount) ?? 0;

            label.Text = totalAmount.ToString() + " Return";
            //Returnlabel.AutoSize = true; // حجم تلقائي
            //Returnlabel.TextAlign = ContentAlignment.MiddleCenter; // توسيط النص
            //Returnlabel.Location = new Point(
            //    (Returnednumberpanel.Width - Returnlabel.Width) / 2,
            //    (Returnednumberpanel.Height - Returnlabel.Height) / 2); // حساب الموقع
        }

        private void Returnednumberpanel_MouseHover_1(object sender, EventArgs e)
        {
            // استدعاء الدالة مرة أخرى لجلب العدد عند التمرير فوق الـ panel
            LoadTotalDailyReturns();
        }

        private void LoadTotalTodayPurchases()
        {
            // حساب إجمالي المشتريات التي تمت اليوم فقط
            int totalPurchases = context.Orders
                .Where(po => po.Sell_date == DateTime.Today) // شرط لتصفية البيانات حسب تاريخ البيع
                .Sum(po => (int?)po.Total_Amount) ?? 0;

            labelTodayPurchases.Text = totalPurchases.ToString() + " Pieces Purchased";
            //labelTodayPurchases.AutoSize = true; // حجم تلقائي
            //labelTodayPurchases.TextAlign = ContentAlignment.MiddleCenter; // توسيط النص
            //labelTodayPurchases.Location = new Point(
            //    (Purchasepanel.Width - labelTodayPurchases.Width) / 2,
            //    (Purchasepanel.Height - labelTodayPurchases.Height) / 2); // حساب الموقع
        }

        private void Purchasepanel_MouseHover_1(object sender, EventArgs e)
        {
            // استدعاء الدالة مرة أخرى لجلب العدد عند التمرير فوق الـ panel
            LoadTotalTodayPurchases();
        }
        private void LoadCategories()
        {
            var categories = context.Categories.Select(c => c.Category_Name).ToList();
            cmbSelecttype.Items.Clear(); // مسح العناصر القديمة
            cmbSelecttype.Items.AddRange(categories.ToArray());
        }

        private void InitializeDataGridView(string selectedOption)
        {
            dgvProducts.Columns.Clear(); // مسح الأعمدة القديمة


            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID" });
            //dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Product ID", DataPropertyName = "ProductID" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Product Name", DataPropertyName = "ProductName" });
            //dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category ID", DataPropertyName = "CategoryID" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity" });

            // إضافة عمود انتهاء الصلاحية فقط إذا كان الخيار "Expiry Date" محددًا
            if (selectedOption == "Expiry Date")
            {
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Expiry Date",
                    DataPropertyName = "ExpiryDate"
                });
            }


            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ملء الأعمدة
            dgvProducts.RowTemplate.Height = 30; // تعيين ارتفاع الصفوف
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // ضبط حجم الصفوف حسب المحتوى
        }


        private void viewbutton_Click(object sender, EventArgs e)
        {

            string selectedCategory = cmbSelecttype.SelectedItem?.ToString();

            string selectedOption = cmbFilter.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCategory) || string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please select a category and a filter option.");
                return;
            }

            // الحصول على ID الفئة المختارة
            var categoryId = context.Categories
                .Where(c => c.Category_Name == selectedCategory)
                .Select(c => c.CategoryID)
                .FirstOrDefault();


            var query = context.Products
                .Where(p => p.Category_ID == categoryId);

            // تطبيق الفلتر بناءً على الخيار المختار
            if (selectedOption == "Low Stock")
            {
                query = query.Where(p => p.Total_Quantity < 4);
            }

            // الحصول على المنتجات مع تواريخ انتهاء الصلاحية فقط عند اختيار "Expiry Date"
            var products = query
                .Select(p => new
                {
                    ProductID = p.Product_ID,
                    ProductName = p.Product_Name,
                    CategoryID = p.Category_ID,
                    Price = p.Price,
                    Quantity = p.Total_Quantity,
                    ExpiryDate = selectedOption == "Expiry Date" ?
                        context.Quantity_Details
                            .Where(q => q.Product_ID == p.Product_ID)
                            .OrderBy(q => q.Expiration_Date)
                            .Select(q => q.Expiration_Date)
                            .FirstOrDefault()
                        : (DateTime?)null
                }).ToList();

            // تصفية المنتجات لتشمل فقط تلك التي لها تواريخ انتهاء صلاحية عندما يكون الخيار "Expiry Date"
            if (selectedOption == "ExpiryDate")
            {
                products = products.Where(p => p.ExpiryDate != null).ToList();
            }

            if (!products.Any())
            {
                MessageBox.Show("No data returned from the database.");
                return;
            }


            InitializeDataGridView(selectedOption); // استدعاء الدالة لتعيين الخصائص

            // إضافة بيانات الصفوف مع رقم الصف
            var productsWithRowNumbers = products.Select((product, index) => new
            {
                ID = index + 1, // إضافة رقم صف افتراضي
                //product.ProductID,
                product.ProductName,
                // product.CategoryID,
                product.Price,
                product.Quantity,
                // product.ExpiryDate
            }).ToList();

            dgvProducts.DataSource = productsWithRowNumbers;


            dgvProducts.AutoResizeColumns(); // حجم الأعمدة لتناسب البيانات
        }

        // تحديث DataGridView بناءً على اختيار الفلتر في ComboBox
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // الحصول على القيمة المختارة من الكومبو بوكس
            string selectedCategory = cmbFilter.SelectedItem?.ToString();

            // تحديث DataGridView بناءً على الفئة المختارة
            if (selectedCategory == "Expiry Date")
            {
                dgvProducts.Columns["ExpiryDate"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["ExpiryDate"].Visible = false;
            }
        }
    }
}


