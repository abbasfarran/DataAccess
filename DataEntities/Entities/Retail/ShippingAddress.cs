using System.ComponentModel;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class ShippingAddress : AddressBase
    {

        [Browsable(false)]
        public int CustomerId { get; set; }
        [Browsable(false)]
        public virtual Customer Customer { get; set; }
    }
}
