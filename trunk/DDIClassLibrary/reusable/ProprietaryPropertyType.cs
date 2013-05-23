namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ProprietaryPropertyType : CodeValueType
    {
        public ProprietaryPropertyType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string name { get; set; }
    }
}