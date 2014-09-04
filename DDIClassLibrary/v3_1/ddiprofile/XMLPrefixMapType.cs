namespace DDIClassLibrary.v3_1.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_1")]
    public class XMLPrefixMapType
    {
        public XMLPrefixMapType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string XMLPrefix { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string XMLNamespace { get; set; }
    }
}