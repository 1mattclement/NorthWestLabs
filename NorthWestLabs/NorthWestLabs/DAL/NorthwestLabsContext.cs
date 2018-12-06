using NorthWestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestLabs.DAL
{
    public class NorthwestLabsContext : DbContext
    {
        public NorthwestLabsContext() : base("NorthWestLabsContext")
        {

        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<AssayCatalog> AssayCatalogs { get; set;}
        public DbSet<AssayTests> AssayTests { get; set; }
        public DbSet<Compound> Compounds{ get; set; }
        public DbSet<CompoundTests> CompoundTests { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<WorkOrders> WorkOrders { get; set; }
        public DbSet<TestCatalog> TestCatalogs { get; set; }
    }
}