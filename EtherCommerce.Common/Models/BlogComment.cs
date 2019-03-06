namespace EtherCommerce.Common.Models
{
    public class BlogComment : CustomerContent
    {
        public string Text { get; set; }
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
