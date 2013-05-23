using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class AttributeType : IdentifiableType
    {
        public AttributeType()
        {
            this.ObjectType = "Attribute";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string AttachmentValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public AttachmentLevelCodeType AttachmentLevel { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType AttachmentGroupReference { get; set; }
    }
}