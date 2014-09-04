namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class IntervalType
    {
        public IntervalType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Anchor { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Increment { get; set; }
    }
}