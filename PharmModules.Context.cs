﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharm_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Pharmacy2Entities : DbContext
    {
        public Pharmacy2Entities()
            : base("name=Pharmacy2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customers_Returns> Customers_Returns { get; set; }
        public virtual DbSet<Customers_Returns_Orders> Customers_Returns_Orders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ExpiringMedicine> ExpiringMedicines { get; set; }
        public virtual DbSet<low_stock> low_stock { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Pharmacy_Useres> Pharmacy_Useres { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Products_Orders> Products_Orders { get; set; }
        public virtual DbSet<Quantity_Details> Quantity_Details { get; set; }
        public virtual DbSet<Return_Supplier_Invoices> Return_Supplier_Invoices { get; set; }
        public virtual DbSet<Return_Supplier_Invoices_Products> Return_Supplier_Invoices_Products { get; set; }
        public virtual DbSet<Supplier_Invoices> Supplier_Invoices { get; set; }
        public virtual DbSet<Supplier_Invoices_Products> Supplier_Invoices_Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    }
}
