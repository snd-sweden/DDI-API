using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_1")]
    public class AttributeType
    {
        public AttributeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType AttributeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public PhysicalTableLocationType PhysicalTableLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Value { get; set; }
    }
}