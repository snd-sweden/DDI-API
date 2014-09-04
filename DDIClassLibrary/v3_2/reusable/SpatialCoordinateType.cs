namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class SpatialCoordinateType
    {
        public SpatialCoordinateType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public PointFormatType coordinateType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CoordinateValue { get; set; }
    }
}