using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class AggregationType
    {
        public AggregationType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CodeValueType AggregationMethod { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public AggregationVariablesType AggregationVariables { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType AggregationVariablesReference { get; set; }
    }
}