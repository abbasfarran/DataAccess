using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Supply
{
    public class Supplier:Person
    {
        public virtual Address Address { get; set; }
    }
}
