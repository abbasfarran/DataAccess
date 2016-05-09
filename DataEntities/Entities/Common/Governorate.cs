using System.Collections.Generic;

namespace DataEntities.Entities.Common
{
    public class Governorate
    {
        public int Id { get; set; }
        public string GovernorateName { get; set; }
        public virtual ICollection<Caza> Cazas { get; set; }
       
    }
}
