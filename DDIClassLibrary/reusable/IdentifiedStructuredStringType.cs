namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class IdentifiedStructuredStringType : IdentifiableType
    {
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public StructuredStringType Content { get; set; }
    }
}