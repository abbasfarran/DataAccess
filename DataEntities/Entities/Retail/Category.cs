using System.Collections.Generic;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual  IEnumerable<Item> Items { get; set; }
    }
}
