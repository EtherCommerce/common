using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class RolePermission : ContentBase
    {
        public int CategoryId { get; set; }
        public RolePermissionCategory Category { get; set; }

        public virtual IList<CustomerRole> CustomerRoles { get; set; }
    }


    public class RolePermissionCategory : ContentBase
    {

    }
}
