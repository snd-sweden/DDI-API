namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class PointType
    {
        public PointType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public SpatialCoordinateType XCoordinate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public SpatialCoordinateType YCoordinate { get; set; }
    }
}