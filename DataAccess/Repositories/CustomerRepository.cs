using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataEntities;
using DataEntities.Entities.Retail;
using System.Windows.Forms;

namespace DataAccess.Repositories
{
    public class CustomerRepository

    {
        private MyContext _db = null;

        public CustomerRepository()
        {
            _db = new MyContext();
        }

        public void Add(Customer customer)
        {
            _db.Customers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            _db.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            _db.Entry<Customer>(customer).State= EntityState.Modified;
        }

        public List<Customer> All()
        {
            var results= _db.Customers.ToList();
            return results;
        }

        public void Save()
        {
            _db.SaveChanges();
           }


    }
}
