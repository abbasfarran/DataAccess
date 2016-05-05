namespace DataEntities.Entities.Common
{
    public class ItemQuantity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
