using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_1")]
    public class DDIProfileType : MaintainableType
    {
        public DDIProfileType()
        {
            this.ObjectType = "DDIProfile";

            this.DDIProfileName = new List<NameType>();
            this.XMLPrefixMap = new List<XMLPrefixMapType>();
            this.Instructions = new List<StructuredStringType>();
            this.Used = new List<UsedType>();
            this.NotUsed = new List<NotUsedType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> DDIProfileName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public double XPathVersion { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public double DDINamespace { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 5)]
        public List<XMLPrefixMapType> XMLPrefixMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<StructuredStringType> Instructions { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<UsedType> Used { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<NotUsedType> NotUsed { get; set; }
    }
}