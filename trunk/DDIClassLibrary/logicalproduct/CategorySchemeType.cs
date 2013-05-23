using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CategorySchemeType : MaintainableType
    {
        public CategorySchemeType()
        {
            this.ObjectType = "CategoryScheme";

            this.CategorySchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.CategorySchemeReference = new List<ReferenceType>();
            this.CategoryGroup = new List<CategoryGroupType>();
            this.Category = new List<CategoryType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CategorySchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<CategoryGroupType> CategoryGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<CategoryType> Category { get; set; }
    }
}