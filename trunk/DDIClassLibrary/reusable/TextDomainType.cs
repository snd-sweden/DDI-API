using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class TextDomainType : TextRepresentationType
    {
        public TextDomainType()
        {
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> Description { get; set; }
    }
}