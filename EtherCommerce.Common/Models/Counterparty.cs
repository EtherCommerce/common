namespace EtherCommerce.Common.Models
{
    public class Counterparty : ContentBase
    {
        public int TypeId { get; set; }
        public CounterpartyType Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Location Location { get; set; }
        public Address Address { get; set; }
        public string SiteUrl { get; set; }
        public string LogoUrl { get; set; }
        public double? Rating { get; set; }
    }


    public class CounterpartyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }


    public class Brand : Counterparty
    {
    }


    public class Manufacturer : Counterparty
    {
    }


    public class Vendor : Counterparty
    {
    }
}
