using System.ComponentModel.DataAnnotations;
using DataEntities.Abstracts;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Supply
{
    public class Supplier:Person
    {
        public int SupplierAdtdressId { get; set; }
        [Required]
        public virtual SupplierAddress SupplierAddress { get; set; }
    }
}
