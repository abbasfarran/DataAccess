using System.Collections.Generic;
using System.ComponentModel;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class Customer : Person
    {
        [Browsable(false)]
        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }
        [Browsable(false)]
        public virtual ICollection<Order> Orders { get; set; }
        [Browsable(false)]
        public virtual ICollection<DebtPayment> DebtPayments { get; set; }
    }
}
