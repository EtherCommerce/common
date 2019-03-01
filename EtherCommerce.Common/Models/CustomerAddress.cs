using System;

namespace EtherCommerce.Common.Models
{
    public class CustomerAddress
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public AddressType AddressType { get; set; }

        public DateTimeOffset? LastUsedAtUtc { get; set; }
    }


    public enum AddressType
    {
        Shipping = 1,
        Billing = 2
    }
}
