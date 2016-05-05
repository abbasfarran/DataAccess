using System;

namespace DataEntities.Entities.Common
{
    public class CashRegister
    {
        public int Id { get; set; }
        public DateTime CashDate { get; set; }
        public float CashValue { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
   }
}