namespace DataEntities.Entities.Common
{
    public class Caza
    {
        public int Id { get; set; }
        public string CazaName { get; set; }
        public int GovernorateId { get; set; }
        public virtual Governorate Governorate { get; set; }
        public override string ToString()
        {
            return CazaName;
        }
    }
}
