using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class BlogPost : ContentLifeTimeBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public bool AllowComments { get; set; }
        public string Tags { get; set; }
        public Meta Meta { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public IList<BlogComment> Comments { get; set; }
    }
}
