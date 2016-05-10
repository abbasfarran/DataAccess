using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataEntities;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;
using DataEntities.Entities.Retail;

namespace DataAccessTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyContext context=new MyContext();
            Governorate governorate1 = new Governorate() { GovernorateName = "محافظة بيروت", Cazas = new List<Caza>() { new Caza() { CazaName = "بيروت" } } };
            Governorate governorate2 = new Governorate()
            {
                GovernorateName = "محافظة جبل لبنان",
                Cazas = new List<Caza>() {
                            new Caza(){CazaName="قضاء كسروان"},
                            new Caza(){CazaName="قضاء المتن"},
                            new Caza(){CazaName="قضاء بعبدا"},
                            new Caza(){CazaName="قضاء عاليه"},
                            new Caza(){CazaName="قضاء الشوف"}
            }

            };
            Governorate governorate3 = new Governorate()
            {
                GovernorateName = "محافظة الشمال",
                Cazas = new List<Caza>()
                {
                           new Caza(){CazaName="قضاء عكار"},
                           new Caza(){CazaName="قضاء طرابلس"},
                           new Caza(){CazaName="قضاء زغرتا"},
                           new Caza(){CazaName="قضاء بشري"},
                           new Caza(){CazaName="قضاء البترون"},
                           new Caza(){CazaName="قضاء الكورة"},
                           new Caza(){CazaName="قضاء الضنية"}

                }
            };
            Governorate governorate4 = new Governorate()
            {
                GovernorateName = "محافظة البقاع",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="قضاء الضنية"},
                new Caza(){CazaName="قضاء الهرمل"},
                new Caza(){CazaName="قضاء بعلبك"},
                new Caza(){CazaName="قضاء زحلة"},
                new Caza(){CazaName="قضاء البقاع الغربي"},
                new Caza(){CazaName="قضاء راشيا"}
                }
            };
            Governorate governorate5 = new Governorate()
            {
                GovernorateName = "محافظة النبطية",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="قضاء صيدا"},
new Caza(){CazaName="قضاء صور"},
new Caza(){CazaName="قضاء جزين"}

            }
            };
            Governorate governorate6 = new Governorate()
            {
                GovernorateName = "محافظة الجنوب",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="قضاء النبطية"},
new Caza(){CazaName="قضاء حاصبيا"},
new Caza(){CazaName="قضاء مرجعيون"},
new Caza(){CazaName="قضاء بنت جبيل"}


            }
            };
            context.Governorates.AddOrUpdate(x => x.GovernorateName,
                governorate1,
                governorate2,
                governorate3,
                governorate4,
                governorate5,
                governorate6
            );


            context.SaveChanges();
            var currency1 = new Currency() { Abreviation = "L.L.", CurrencyValueInLocal = 1, Description = "ليرة لبنانية" };
            var currency2 = new Currency() { Abreviation = "USD", CurrencyValueInLocal = 1507, Description = "دولار امريكي" };
            context.Currencies.AddOrUpdate(x => x.Abreviation, currency1, currency2);
            context.SaveChanges();
            var itemtype1 = new ItemType() { Description = "Retail" };
            var itemtype2 = new ItemType() { Description = "Supply" };
            context.ItemTypes.AddOrUpdate(x => x.Description, itemtype1, itemtype2);
            context.SaveChanges();
            Caza custcaza = context.Cazas.FirstOrDefault(x => x.CazaName == "قضاء مرجعيون");
            Customer customer1 = new Customer()
            {
                CompanyName = "Balabito Co.",
                Email = "boss@balabito.com",
                FirstName = "tari",
                LastName = "lala",
                Mobile = "0345899",
                LandLine = "354345",
                ShippingAddresses = new List<ShippingAddress>() { new ShippingAddress() { CazaId = custcaza.Id, Street = "bayyad", Village = "souwed" }, new ShippingAddress() { CazaId = custcaza.Id, Street = "hamra", Village = "safra" } }
            };
            context.Customers.AddOrUpdate(x=>x.FirstName,customer1);
            context.SaveChanges();
            Assert.AreEqual(1,context.Customers.Count());
            Assert.AreEqual(2,context.ShippingAddresses.Count());
        }
    }
}
