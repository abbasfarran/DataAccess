using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataEntities;
using DataEntities.Abstracts;
using DataEntities.Entities.Retail;

namespace DataAccessTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new MyContext();
            var customer = new Customer
            {
                FirstName = "abbas",
                LastName = "farran",
                LandLine = "07763375",
                CompanyName = "Farran Co."
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            var customers=new List<Customer>();
            customers = context.Customers.ToList();
            Assert.AreEqual(1,customers.Count());
        }
    }
}
