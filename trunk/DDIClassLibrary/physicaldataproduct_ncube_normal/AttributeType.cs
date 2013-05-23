using DDIClassLibrary.physicaldataproduct;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_1")]
    public class AttributeType
    {
        public AttributeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType AttributeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", Order = 1)]
        public PhysicalLocationType PhysicalLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Value { get; set; }
    }
}