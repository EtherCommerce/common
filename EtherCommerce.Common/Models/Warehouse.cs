namespace EtherCommerce.Common.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public long? VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public bool IsDeleted { get; set; }
    }
}
