using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class AggregationType
    {
        public AggregationType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Method { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public VariableSetType VariableSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType VariableSetReference { get; set; }
    }
}