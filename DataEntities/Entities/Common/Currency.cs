namespace DataEntities.Entities.Common
{
    public class Currency
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Abreviation { get; set; }
        public float CurrencyValueInLocal { get; set; }
    }
}
