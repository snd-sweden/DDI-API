using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class MeasureDefinitionType : IdentifiableType
    {
        public MeasureDefinitionType()
        {

        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public AggregationDefinitionType AggregationDefinition { get; set; }
    }
}