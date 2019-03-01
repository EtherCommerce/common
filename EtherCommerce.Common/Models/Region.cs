namespace EtherCommerce.Common.Models
{
    public class Region
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsPublished { get; set; }
    }
}
