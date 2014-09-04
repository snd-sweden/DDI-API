using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CategoryGroupType : VersionableType
    {
        public CategoryGroupType()
        {
            this.ObjectType = "CategoryGroup";

            this.CategoryGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.Category = new List<CategoryType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CategoryGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 3)]
        public List<CategoryType> Category { get; set; }
    }
}