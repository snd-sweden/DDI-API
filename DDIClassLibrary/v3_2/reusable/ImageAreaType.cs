namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ImageAreaType
    {
        public ImageAreaType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ShapeCodedType Shape { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Coordinates { get; set; }
    }
}