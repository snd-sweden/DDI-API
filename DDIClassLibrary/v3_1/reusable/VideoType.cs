namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class VideoType
    {
        public VideoType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public VideoClipTypeCodedType VideoClipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string OtherVideoClipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string VideoClipBegin { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string VideoClipEnd { get; set; }
    }
}