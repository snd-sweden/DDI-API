using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class ConditionalVariableReferenceType : ReferenceType
    {
        public ConditionalVariableReferenceType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public RelatedValueType RelatedValue { get; set; }
    }
}