namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class AudioType
    {
        public AudioType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public AudioClipTypeCodedType AudioClipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string OtherAudioClipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string AudioClipBegin { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string AudioClipEnd { get; set; }
    }
}