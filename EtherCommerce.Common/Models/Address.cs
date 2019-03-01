using System;

namespace EtherCommerce.Common.Models
{
    public class Address
    {
        public string ContactName { get; set; }
        public string Phone { get; set; }

        public string ZipCode { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int? RegionId { get; set; }
        public Region Region { get; set; }
        public string City { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public DateTime CreatedAtUtc { get; set; }
    }
}
