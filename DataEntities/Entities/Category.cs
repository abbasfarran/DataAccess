using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual  IEnumerable<Item> Items { get; set; }
    }
}
