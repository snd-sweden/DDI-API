namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class VideoType
    {
        public VideoType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfVideoClip { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string VideoClipBegin { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string VideoClipEnd { get; set; }
    }
}