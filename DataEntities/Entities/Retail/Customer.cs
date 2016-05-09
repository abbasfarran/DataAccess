using System.Collections.Generic;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class Customer : Person
    {
        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<DebtPayment> DebtPayments { get; set; }
    }
}
