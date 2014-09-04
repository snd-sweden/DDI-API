namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class StandardKeyValuePairType
    {
        public StandardKeyValuePairType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType AttributeKey { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType AttributeValue { get; set; }
    }
}