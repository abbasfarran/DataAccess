using System;
using System.Collections.Generic;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Supply
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<SupplyOrderDetail> SupplyOrderDetails { get; set; }



    }
}
