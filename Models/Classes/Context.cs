﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<BillPen> BillPens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesMovement> SalesMovements { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}