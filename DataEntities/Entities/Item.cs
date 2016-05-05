using System.Collections.Generic;

namespace DataEntities.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public  int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual IEnumerable<Option> Options { get; set; }


    }
}
