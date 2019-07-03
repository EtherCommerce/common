namespace EtherCommerce.Common.Models
{
    public class Store : ContentBase
    {
        public string Url { get; set; }
        public int PrimaryCurrencyId { get; set; }
        public Currency PrimaryCurrency { get; set; }
    }
}
