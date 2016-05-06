using System;
using System.Collections.Generic;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int AddressId { get; set; }
        public virtual ShippingAddress ShippingAddress { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public int Discount { get; set; }


    }
}
