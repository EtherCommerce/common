using System;

namespace EtherCommerce.Common.Models
{
    public class ContentBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public int LastUpdateById { get; set; }
        public User LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
