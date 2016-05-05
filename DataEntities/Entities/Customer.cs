using System.Collections.Generic;

namespace DataEntities.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<ShippingAddress> ShippingAddresses { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
