using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
