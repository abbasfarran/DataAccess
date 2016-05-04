using DataEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class MyContext : DbContext
    {
        public DbSet<Caza> Cazas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
    }
}
