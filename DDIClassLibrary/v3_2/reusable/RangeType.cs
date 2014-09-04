namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RangeType
    {
        public RangeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string RangeUnit { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public RangeValueType MinimumValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public RangeValueType MaximumValue { get; set; }
    }
}