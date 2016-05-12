using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataEntities.Entities.Retail;

namespace DataAccess.Repositories
{
    public class ShippingAddressRepository
    {
        private MyContext _db;

        public ShippingAddressRepository(MyContext db)
        {
            _db = db;
        }
        public void Add(ShippingAddress shippingAddress)
        {
            _db.ShippingAddresses.Add(shippingAddress);

        }

        public void Remove(ShippingAddress shippingAddress)
        {
            _db.ShippingAddresses.Remove(shippingAddress);
        }

        public void Update(ShippingAddress shippingAddress)
        {
            _db.Entry<ShippingAddress>(shippingAddress).State = EntityState.Modified;
        }

        public List<ShippingAddress> All()
        {
            var results = _db.ShippingAddresses.ToList();
            return results;
        }

        public void Save()
        {
            _db.SaveChanges();

        }
    }
}
