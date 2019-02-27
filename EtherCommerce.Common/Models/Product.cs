using System;
using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Product : ContentBase
    {
        public string ShortDescription { get; set; }
        public string Specification { get; set; }
        public string SKU { get; set; }
        public int CategoryId { get; set; }
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
        /// <summary>
        /// Available stock at which we should reorder
        /// </summary>
        public int RestockThreshold { get; set; }
        /// <summary>
        /// Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
        /// </summary>
        public int MaxStockThreshold { get; set; }
        
        public bool DisableBuyButton { get; set; }
        public bool DisableWishlistButton { get; set; }
        public bool DisableAddToCompareListButton { get; set; }
        public bool DisableComments { get; set; }
        public bool HideStockAvailability { get; set; }

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
