namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class InternationalIdentifierType
    {
        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public string IdentifierContent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public CodeValueType ManagingAgency { get; set; }

    }
}
