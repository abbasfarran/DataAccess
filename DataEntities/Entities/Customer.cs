using System.Collections.Generic;
using DataEntities.Abstracts;

namespace DataEntities.Entities
{
    public class Customer : Person
    {
        public virtual IEnumerable<Address> ShippingAddresses { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
