namespace EtherCommerce.Common.Models
{
    public class ProductOptionValue
    {
        public long Id { get; set; }
        public long OptionId { get; set; }
        public ProductOption Option { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
        public string DisplayType { get; set; }
        public int SortIndex { get; set; }
    }


    public class ProductOption
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
