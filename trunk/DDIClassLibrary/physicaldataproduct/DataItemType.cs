using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class DataItemType
    {
        public DataItemType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public PhysicalLocationType PhysicalLocation { get; set; }
    }
}