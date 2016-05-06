using System.Collections.Generic;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class Customer : Person
    {
        public virtual IEnumerable<ShippingAddress> ShippingAddresses { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<DebtPayment> DebtPayments { get; set; }
    }
}
