using System;
using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Product : ContentBase
    {
        public string ShortDescription { get; set; }
        public string Specification { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }

        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public decimal Cost { get; set; }
        public int? TaxRateId { get; set; }
        public TaxRate TaxRate { get; set; }

        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceStartAt { get; set; }
        public DateTime? SpecialPriceEndAt { get; set; }

        public bool IsAllowToOrder { get; set; }
        public int StockQuantity { get; set; }
        // Available stock at which we should reorder
        public int RestockThreshold { get; set; }
        // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
        public int MaxStockThreshold { get; set; }

        public int DisplayOrder { get; set; }
        public int ReviewsCount { get; set; }
        public double RatingAverage { get; set; }
        public Meta Meta { get; set; }
        public Media ThumbnailImage { get; set; }

        public IList<ProductMedia> Medias { get; protected set; } = new List<ProductMedia>();
        public IList<ProductLink> ProductLinks { get; protected set; } = new List<ProductLink>();
        public IList<ProductLink> LinkedProductLinks { get; protected set; } = new List<ProductLink>();
        public IList<ProductAttributeValue> AttributeValues { get; protected set; } = new List<ProductAttributeValue>();
        public IList<ProductOptionValue> OptionValues { get; protected set; } = new List<ProductOptionValue>();
    }
}
