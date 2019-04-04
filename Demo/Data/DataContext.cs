using Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Connection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}