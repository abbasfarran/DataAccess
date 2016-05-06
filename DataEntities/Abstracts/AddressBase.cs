using DataEntities.Entities.Common;

namespace DataEntities.Abstracts
{
    public class AddressBase
    {
        public int Id { get; set; }
        public int GovernorateId { get; set; }
        public int CazaId { get; set;}
        public Governorate Governorate { get; set; }
        public Caza Caza { get; set; }
        public string Village { get; set; }
        public string Street { get; set; }
    }
}