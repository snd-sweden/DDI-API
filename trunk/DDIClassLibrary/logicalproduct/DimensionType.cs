using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class DimensionType
    {
        public DimensionType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int rank { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }
    }
}