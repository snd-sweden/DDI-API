namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographyCodeType
    {
        public GeographyCodeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Value { get; set; }
    }
}