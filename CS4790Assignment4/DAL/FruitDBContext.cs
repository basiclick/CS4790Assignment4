using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CS4790Assignment4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace CS4790Assignment4.DAL
{
    public class FruitDBContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<Vendor> Vendors { get; set; }
    }
}