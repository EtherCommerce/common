namespace EtherCommerce.Common.Models
{
    public class ProductLink
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long LinkedProductId { get; set; }
        public Product LinkedProduct { get; set; }
        public ProductLinkType LinkType { get; set; }
    }


    public enum ProductLinkType
    {
        /// <summary>
        /// Совместим только с этим товаром
        /// </summary>
        Super = 1,

        /// <summary>
        /// Связанный товар
        /// </summary>
        Related = 2,

        /// <summary>
        /// Перекрестная продажа
        /// </summary>
        CrossSell = 3,

        /// <summary>
        /// Допродажа
        /// </summary>
        UpSell = 4
    }
}
