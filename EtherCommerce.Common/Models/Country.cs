using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsoAlpha2 { get; set; }
        public string IsoAlpha3 { get; set; }
        public string IsoNumeric { get; set; }

        public bool IsBillingEnabled { get; set; }
        public bool IsShippingEnabled { get; set; }

        public bool IsPublished { get; set; }

        public IList<Region> Regions { get; set; }
    }
}
