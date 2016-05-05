using System;
using DataEntities.Entities.Common;

namespace DataEntities.Entities.Retail
{
    public class DebtPayment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float PaymentValue { get; set; }
        public int CurrencyId   { get; set; }
        public virtual Currency Currency { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}
