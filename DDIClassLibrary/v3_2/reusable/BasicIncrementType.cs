namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class BasicIncrementType
    {
        public BasicIncrementType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string increment { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string startValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string endValue { get; set; }
    }
}