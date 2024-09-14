using Pharm_Project;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PharmacyManagment
{
    public partial class lowNotification : Form
    {
        Pharmacy2Entities context = new Pharmacy2Entities();

        public lowNotification()
        {
            InitializeComponent();
            InitializeNotifications();
        }

        private void InitializeNotifications()
        {
            var lowMedicines = context.low_stock.ToList();

            //foreach (var item in expiringMedicines)
            //{
            //    Label label = new Label();
            //    label.Text = $"Warning: The medicine {item.MedicineName} will expire in 30 days.";
            //    label.AutoSize = true;
            //    label.Font = new Font("Arial", 14, FontStyle.Regular);
            //    label.ForeColor = Color.LightCoral;
            //    label.Margin = new Padding(0, 10, 0, 10);
            //    // Add label to the FlowLayoutPanel
            //    flowLayoutPanel1.Controls.Add(label);
            //}
            foreach (var item in lowMedicines)
            {
                Label label = new Label();
                //Button button = new Button();
                //button.Text = "confoirm";
                //button.Size = new Size(100, 30); // تحديد حجم الزر
                //button.Font = new Font("Arial", 12, FontStyle.Regular);
                //button.BackColor = Color.FromArgb(0, 64, 64);
                //button.ForeColor = Color.White; // لون النص الأبيض

                //// إزالة الحدود
                //button.FlatStyle = FlatStyle.Flat;
                //button.FlatAppearance.BorderSize = 0;
                //button.Margin = new Padding(10, 5, 5, 10);
                //button.Click += new EventHandler(Button_Click);
                label.Text = $"The available quantity of the medicine {item.MedicineName} is about three boxes.";

                label.AutoSize = true;
                label.Font = new Font("Arial", 14, FontStyle.Regular);
                label.ForeColor = Color.LightCoral;
                label.Margin = new Padding(0, 10, 0, 10);
                //Add label to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(label);
                //flowLayoutPanel1.Controls.Add(button);
                // void Button_Click(object sender, EventArgs e)
                //{
                //    Button clickedButton = sender as Button;
                //    if (clickedButton != null)
                //    {
                //     context.low_stock.Remove(item);
                //        context.SaveChanges();
                //        label.Visible= false;
                //        button.Visible= false;
                //    }
                //}

            }
        }

        
    }
}
