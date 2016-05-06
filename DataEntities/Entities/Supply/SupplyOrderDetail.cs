using DataEntities.Entities.Common;

namespace DataEntities.Entities.Supply
{
    public class SupplyOrderDetail
    {
        public int Id { get; set; }
        public int SupplyOrderId { get; set; }
        public virtual SupplyOrder SupplyOrder { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
