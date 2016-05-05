using System;

namespace DataEntities.Entities.Common
{
    public class ItemPrice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public float Price { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }


    }
}
