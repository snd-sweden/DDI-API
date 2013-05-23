namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
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