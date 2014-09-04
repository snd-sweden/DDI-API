using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_1")]
    public class DimensionType
    {
        public DimensionType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int rank { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string value { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }
    }
}