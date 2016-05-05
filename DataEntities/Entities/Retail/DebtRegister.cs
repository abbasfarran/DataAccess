namespace DataEntities.Entities.Retail
{
    public class DebtRegister
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
