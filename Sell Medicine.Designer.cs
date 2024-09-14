
namespace PharmacyManagment
{
    partial class Sell_Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quantitytxtbox = new System.Windows.Forms.TextBox();
            this.totalpricetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addcartBtn = new System.Windows.Forms.Button();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceperunittxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.noofunitstxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameproducttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoicecodetxt = new System.Windows.Forms.TextBox();
            this.invoiccodelbl = new System.Windows.Forms.Label();
            this.comboBoxempname = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerphonetxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.customernametxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.quantitytxtbox);
            this.panel2.Controls.Add(this.totalpricetxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.removeBtn);
            this.panel2.Controls.Add(this.totalpricelbl);
            this.panel2.Controls.Add(this.purchaseBtn);
            this.panel2.Controls.Add(this.dgvcart);
            this.panel2.Controls.Add(this.addcartBtn);
            this.panel2.Controls.Add(this.pricetxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.priceperunittxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.noofunitstxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nameproducttxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(381, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 535);
            this.panel2.TabIndex = 4;
            // 
            // quantitytxtbox
            // 
            this.quantitytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxtbox.Location = new System.Drawing.Point(26, 188);
            this.quantitytxtbox.Name = "quantitytxtbox";
            this.quantitytxtbox.Size = new System.Drawing.Size(251, 29);
            this.quantitytxtbox.TabIndex = 20;
            // 
            // totalpricetxt
            // 
            this.totalpricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricetxt.Location = new System.Drawing.Point(334, 188);
            this.totalpricetxt.Name = "totalpricetxt";
            this.totalpricetxt.Size = new System.Drawing.Size(253, 29);
            this.totalpricetxt.TabIndex = 19;
            this.totalpricetxt.TextChanged += new System.EventHandler(this.totalpricetxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Price";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(466, 481);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(131, 45);
            this.removeBtn.TabIndex = 17;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelbl.Location = new System.Drawing.Point(189, 491);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(109, 26);
            this.totalpricelbl.TabIndex = 16;
            this.totalpricelbl.Text = "Total Price";
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.ForeColor = System.Drawing.Color.White;
            this.purchaseBtn.Location = new System.Drawing.Point(38, 482);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(145, 44);
            this.purchaseBtn.TabIndex = 15;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = false;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // dgvcart
            // 
            this.dgvcart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.TotalPrice});
            this.dgvcart.Location = new System.Drawing.Point(80, 268);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.Size = new System.Drawing.Size(443, 199);
            this.dgvcart.TabIndex = 14;
            this.dgvcart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcart_CellValueChanged);
            this.dgvcart.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvcart_RowsAdded);
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 150;
            // 
            // addcartBtn
            // 
            this.addcartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addcartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcartBtn.ForeColor = System.Drawing.Color.White;
            this.addcartBtn.Location = new System.Drawing.Point(334, 223);
            this.addcartBtn.Name = "addcartBtn";
            this.addcartBtn.Size = new System.Drawing.Size(207, 38);
            this.addcartBtn.TabIndex = 12;
            this.addcartBtn.Text = "Add to Cart";
            this.addcartBtn.UseVisualStyleBackColor = false;
            this.addcartBtn.Click += new System.EventHandler(this.addcartBtn_Click);
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(335, 117);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(252, 29);
            this.pricetxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity";
            // 
            // priceperunittxt
            // 
            this.priceperunittxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceperunittxt.Location = new System.Drawing.Point(25, 117);
            this.priceperunittxt.Name = "priceperunittxt";
            this.priceperunittxt.Size = new System.Drawing.Size(252, 29);
            this.priceperunittxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price per Unit";
            // 
            // noofunitstxt
            // 
            this.noofunitstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofunitstxt.Location = new System.Drawing.Point(336, 49);
            this.noofunitstxt.Name = "noofunitstxt";
            this.noofunitstxt.Size = new System.Drawing.Size(251, 29);
            this.noofunitstxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. of Units";
            // 
            // nameproducttxt
            // 
            this.nameproducttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameproducttxt.Location = new System.Drawing.Point(19, 51);
            this.nameproducttxt.Name = "nameproducttxt";
            this.nameproducttxt.Size = new System.Drawing.Size(252, 29);
            this.nameproducttxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Medicine Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sell Medicine";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvsearch);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 282);
            this.panel1.TabIndex = 3;
            // 
            // dgvsearch
            // 
            this.dgvsearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.Location = new System.Drawing.Point(14, 77);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.Size = new System.Drawing.Size(326, 193);
            this.dgvsearch.TabIndex = 4;
            this.dgvsearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsearch_CellClick);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(233, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 36);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(14, 36);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(211, 36);
            this.searchtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.invoicecodetxt);
            this.panel3.Controls.Add(this.invoiccodelbl);
            this.panel3.Controls.Add(this.comboBoxempname);
            this.panel3.Controls.Add(this.customerphonetxt);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.customernametxt);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 246);
            this.panel3.TabIndex = 6;
            // 
            // invoicecodetxt
            // 
            this.invoicecodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicecodetxt.Location = new System.Drawing.Point(150, 21);
            this.invoicecodetxt.Name = "invoicecodetxt";
            this.invoicecodetxt.Size = new System.Drawing.Size(190, 29);
            this.invoicecodetxt.TabIndex = 32;
            // 
            // invoiccodelbl
            // 
            this.invoiccodelbl.AutoSize = true;
            this.invoiccodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiccodelbl.Location = new System.Drawing.Point(10, 21);
            this.invoiccodelbl.Name = "invoiccodelbl";
            this.invoiccodelbl.Size = new System.Drawing.Size(101, 20);
            this.invoiccodelbl.TabIndex = 31;
            this.invoiccodelbl.Text = "Invoice Code";
            // 
            // comboBoxempname
            // 
            this.comboBoxempname.DataSource = this.employeesBindingSource1;
            this.comboBoxempname.DisplayMember = "Employee_Name";
            this.comboBoxempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxempname.FormattingEnabled = true;
            this.comboBoxempname.Location = new System.Drawing.Point(150, 110);
            this.comboBoxempname.Name = "comboBoxempname";
            this.comboBoxempname.Size = new System.Drawing.Size(190, 32);
            this.comboBoxempname.TabIndex = 30;
            this.comboBoxempname.ValueMember = "Employee_ID";
            this.comboBoxempname.SelectedIndexChanged += new System.EventHandler(this.comboBoxempname_SelectedIndexChanged);
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            // 
            // customerphonetxt
            // 
            this.customerphonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerphonetxt.Location = new System.Drawing.Point(150, 199);
            this.customerphonetxt.Name = "customerphonetxt";
            this.customerphonetxt.Size = new System.Drawing.Size(190, 29);
            this.customerphonetxt.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // customernametxt
            // 
            this.customernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametxt.Location = new System.Drawing.Point(150, 158);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(190, 29);
            this.customernametxt.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Customer Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Customer Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "sell Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Employee Name";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            // 
            // Sell_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Sell_Medicine";
            this.Text = "Sell_Medicine";
            this.Load += new System.EventHandler(this.Sell_Medicine_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox totalpricetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.Button addcartBtn;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceperunittxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noofunitstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameproducttxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxempname;
        private System.Windows.Forms.TextBox customerphonetxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox customernametxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.TextBox quantitytxtbox;
       
        private System.Windows.Forms.BindingSource employeesBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        
        private System.Windows.Forms.BindingSource employeesBindingSource1;
      
        private System.Windows.Forms.TextBox invoicecodetxt;
        private System.Windows.Forms.Label invoiccodelbl;
    }
}