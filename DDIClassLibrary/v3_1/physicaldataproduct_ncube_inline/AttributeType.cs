using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class AttributeType
    {
        public AttributeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType AttributeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Value { get; set; }
    }
}