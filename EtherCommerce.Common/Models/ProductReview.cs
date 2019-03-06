namespace EtherCommerce.Common.Models
{
    public class ProductReview : CustomerContent
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Rating { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
    }
}
