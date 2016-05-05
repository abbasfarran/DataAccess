using DataEntities.Entities;
using System.Data.Entity;

namespace DataEntities
{
    public class MyContext : DbContext
    {
        public DbSet<Caza> Cazas { get; set; }
        public DbSet<Person> Customers { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Address> ShippingAddresses { get; set; }
    }
}
