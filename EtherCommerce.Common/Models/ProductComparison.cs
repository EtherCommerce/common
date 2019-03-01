using System;

namespace EtherCommerce.Common.Models
{
    public class ProductComparison
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
