using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class ShippingAddress : AddressBase
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
