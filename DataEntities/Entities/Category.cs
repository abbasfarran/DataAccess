using System.Collections.Generic;

namespace DataEntities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual  IEnumerable<Item> Items { get; set; }
    }
}
