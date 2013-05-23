namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ExcludeType
    {
        public ExcludeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IDType ID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public VersionType Version { get; set; }
    }
}