using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class SourceTargetLinkType
    {
        public SourceTargetLinkType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType SourceLinkVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType TargetLinkVariableReference { get; set; }
    }
}