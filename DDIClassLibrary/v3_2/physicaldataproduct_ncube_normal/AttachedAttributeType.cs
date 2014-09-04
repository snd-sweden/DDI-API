using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_2")]
    public class AttachedAttributeType
    {
        public AttachedAttributeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType AttributeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", Order = 1)]
        public PhysicalLocationType PhysicalLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public ValueType Value { get; set; }
    }
}