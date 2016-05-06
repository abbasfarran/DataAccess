using DataEntities.Entities;
using System.Data.Entity;
using System.Security.Cryptography;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;
using DataEntities.Entities.Retail;
using DataEntities.Entities.Supply;

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
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ItemPrice> ItemPrices { get; set; }
        public DbSet<ItemQuantity> ItemQuantities { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<OptionCategory> OptionCategories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DebtPayment> DebtPayments { get; set; }
        public DbSet<DebtRegister> DebtRegisters { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<SupplyOrderDetail> SupplyOrderDetails { get; set; }

        public MyContext()
        {
            Database.SetInitializer<MyContext>(new DropCreateDatabaseIfModelChanges<MyContext>());
        }
    }
}
