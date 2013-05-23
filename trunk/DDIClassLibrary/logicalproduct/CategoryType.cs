using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CategoryType : VersionableType
    {
        public CategoryType()
        {
            this.ObjectType = "Category";

            this.CategoryName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool missing { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CategoryName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public GenerationType Generation { get; set; }
    }
}