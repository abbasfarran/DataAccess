namespace DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CashRegisters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CashDate = c.DateTime(nullable: false),
                        CashValue = c.Single(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        PaymentMethodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethodId, cascadeDelete: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.PaymentMethodId);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Abreviation = c.String(),
                        CurrencyValueInLocal = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cazas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CazaName = c.String(),
                        GovernorateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Governorates", t => t.GovernorateId, cascadeDelete: true)
                .Index(t => t.GovernorateId);
            
            CreateTable(
                "dbo.Governorates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GovernorateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CompanyName = c.String(),
                        Mobile = c.String(),
                        LandLine = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DebtPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        PaymentValue = c.Single(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.DebtRegisters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        ShippingAddress_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.ShippingAddresses", t => t.ShippingAddress_Id)
                .Index(t => t.CustomerId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ShippingAddress_Id);
            
            CreateTable(
                "dbo.ShippingAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CazaId = c.Int(nullable: false),
                        Village = c.String(),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cazas", t => t.CazaId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CazaId);
            
            CreateTable(
                "dbo.ItemPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.CurrencyId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        ItemTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ItemTypes", t => t.ItemTypeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ItemTypeId);
            
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemQuantities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.OptionCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        OptionCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OptionCategories", t => t.OptionCategoryId, cascadeDelete: true)
                .Index(t => t.OptionCategoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SupplierAdtdressId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CompanyName = c.String(),
                        Mobile = c.String(),
                        LandLine = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SupplierAddresses", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.SupplierAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        CazaId = c.Int(nullable: false),
                        Village = c.String(),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cazas", t => t.CazaId, cascadeDelete: true)
                .Index(t => t.CazaId);
            
            CreateTable(
                "dbo.SupplyOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplyOrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.SupplyOrders", t => t.SupplyOrderId, cascadeDelete: true)
                .Index(t => t.SupplyOrderId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.SupplyOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.CurrencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplyOrderDetails", "SupplyOrderId", "dbo.SupplyOrders");
            DropForeignKey("dbo.SupplyOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplyOrders", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.SupplyOrderDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Suppliers", "Id", "dbo.SupplierAddresses");
            DropForeignKey("dbo.SupplierAddresses", "CazaId", "dbo.Cazas");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Options", "OptionCategoryId", "dbo.OptionCategories");
            DropForeignKey("dbo.ItemQuantities", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemPrices", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "ItemTypeId", "dbo.ItemTypes");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ItemPrices", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.DebtRegisters", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ShippingAddress_Id", "dbo.ShippingAddresses");
            DropForeignKey("dbo.ShippingAddresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ShippingAddresses", "CazaId", "dbo.Cazas");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.DebtPayments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.DebtPayments", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Cazas", "GovernorateId", "dbo.Governorates");
            DropForeignKey("dbo.CashRegisters", "PaymentMethodId", "dbo.PaymentMethods");
            DropForeignKey("dbo.CashRegisters", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.SupplyOrders", new[] { "CurrencyId" });
            DropIndex("dbo.SupplyOrders", new[] { "SupplierId" });
            DropIndex("dbo.SupplyOrderDetails", new[] { "ItemId" });
            DropIndex("dbo.SupplyOrderDetails", new[] { "SupplyOrderId" });
            DropIndex("dbo.SupplierAddresses", new[] { "CazaId" });
            DropIndex("dbo.Suppliers", new[] { "Id" });
            DropIndex("dbo.OrderDetails", new[] { "ItemId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Options", new[] { "OptionCategoryId" });
            DropIndex("dbo.ItemQuantities", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "ItemTypeId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropIndex("dbo.ItemPrices", new[] { "CurrencyId" });
            DropIndex("dbo.ItemPrices", new[] { "ItemId" });
            DropIndex("dbo.ShippingAddresses", new[] { "CazaId" });
            DropIndex("dbo.ShippingAddresses", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "ShippingAddress_Id" });
            DropIndex("dbo.Orders", new[] { "CurrencyId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.DebtRegisters", new[] { "OrderId" });
            DropIndex("dbo.DebtPayments", new[] { "CustomerId" });
            DropIndex("dbo.DebtPayments", new[] { "CurrencyId" });
            DropIndex("dbo.Cazas", new[] { "GovernorateId" });
            DropIndex("dbo.CashRegisters", new[] { "PaymentMethodId" });
            DropIndex("dbo.CashRegisters", new[] { "CurrencyId" });
            DropTable("dbo.SupplyOrders");
            DropTable("dbo.SupplyOrderDetails");
            DropTable("dbo.SupplierAddresses");
            DropTable("dbo.Suppliers");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Options");
            DropTable("dbo.OptionCategories");
            DropTable("dbo.ItemQuantities");
            DropTable("dbo.ItemTypes");
            DropTable("dbo.Items");
            DropTable("dbo.ItemPrices");
            DropTable("dbo.ShippingAddresses");
            DropTable("dbo.Orders");
            DropTable("dbo.DebtRegisters");
            DropTable("dbo.DebtPayments");
            DropTable("dbo.Customers");
            DropTable("dbo.Governorates");
            DropTable("dbo.Cazas");
            DropTable("dbo.Categories");
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.Currencies");
            DropTable("dbo.CashRegisters");
        }
    }
}
