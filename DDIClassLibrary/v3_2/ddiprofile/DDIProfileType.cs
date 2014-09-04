using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_2")]
    public class DDIProfileType : MaintainableType
    {
        public DDIProfileType()
        {
            this.DDIProfileName = new List<NameType>();
            this.XMLPrefixMap = new List<XMLPrefixMapType>();
            this.Used = new List<UsedType>();
            this.NotUsed = new List<NotUsedType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> DDIProfileName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType ApplicationOfProfile { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public StructuredStringType Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public decimal XPathVersion { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public decimal DDINamespace { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<XMLPrefixMapType> XMLPrefixMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public StructuredStringType Instructions { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<UsedType> Used { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<NotUsedType> NotUsed { get; set; }
    }
}