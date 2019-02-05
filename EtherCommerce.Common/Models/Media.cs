namespace EtherCommerce.Common.Models
{
    public class Media
    {
        public long Id { get; set; }
        public MediaType Type { get; set; }
        public string Caption { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
    }


    public class ProductMedia
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public long MediaId { get; set; }
        public Media Media { get; set; }
        public int DisplayOrder { get; set; }
    }


    public enum MediaType
    {
        Image = 10,
        Video = 20,
        File = 30
    }
}
