namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
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