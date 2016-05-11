using System.ComponentModel;
using DataEntities.Entities.Common;

namespace DataEntities.Abstracts
{
    public class AddressBase
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int CazaId { get; set;}
        public virtual Caza Caza { get; set; }
        public string Village { get; set; }
        public string Street { get; set; }
    }
}