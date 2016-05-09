using System.Collections.Generic;
using System.Reflection.Emit;
using DataEntities.Entities.Retail;

namespace DataEntities.Entities.Common
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public  int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
      


    }
}
