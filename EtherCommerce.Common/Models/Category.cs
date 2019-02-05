using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Category : ContentBase
    {
        public Media ThumbnailImage { get; set; }
        public Meta Meta { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public IList<Category> Children { get; protected set; } = new List<Category>();

    }
}
