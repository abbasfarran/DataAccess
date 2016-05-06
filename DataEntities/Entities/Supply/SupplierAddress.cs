using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities.Abstracts;

namespace DataEntities.Entities.Supply
{
    public class SupplierAddress:AddressBase
    {
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
