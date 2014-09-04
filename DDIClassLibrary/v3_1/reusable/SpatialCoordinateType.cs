namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
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