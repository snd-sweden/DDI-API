namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class NumberRangeType
    {
        public NumberRangeType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string regExp { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public NumberRangeValueType Low { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public NumberRangeValueType High { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public double TopCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public double BottomCode { get; set; }
    }
}