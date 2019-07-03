using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class CustomerRole : ContentBase
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public bool IsSystemRole { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }

        public IList<RolePermission> Permissions { get; set; }
    }
}
