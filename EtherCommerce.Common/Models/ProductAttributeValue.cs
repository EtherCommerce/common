using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class ProductAttributeValue
    {
        public long Id { get; set; }
        public long AttributeId { get; set; }
        public ProductAttribute Attribute { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }


    public class ProductAttribute
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long GroupId { get; set; }
        public ProductAttributeGroup Group { get; set; }
        public IList<ProductTemplateProductAttribute> ProductTemplates { get; protected set; } = new List<ProductTemplateProductAttribute>();
    }


    public class ProductAttributeGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }


    public class ProductTemplateProductAttribute
    {
        public long ProductTemplateId { get; set; }
        public ProductTemplate ProductTemplate { get; set; }
        public long ProductAttributeId { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
    }


    public class ProductTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<ProductTemplateProductAttribute> ProductAttributes { get; protected set; } = new List<ProductTemplateProductAttribute>();

        public void AddAttribute(long attributeId)
        {
            var productTempateProductAttribute = new ProductTemplateProductAttribute
            {
                ProductTemplate = this,
                ProductAttributeId = attributeId
            };
            ProductAttributes.Add(productTempateProductAttribute);
        }
    }
}
