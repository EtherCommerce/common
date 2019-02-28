using System;

namespace EtherCommerce.Common.Models
{
    public class ContentBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdminComment { get; set; }
        public int DisplayOrder { get; set; }

        public int CreatedById { get; set; }
        public SystemAccount CreatedBy { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public int LastUpdateById { get; set; }
        public SystemAccount LastUpdateBy { get; set; }
        public DateTime LastUpdateAtUtc { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    }
}
