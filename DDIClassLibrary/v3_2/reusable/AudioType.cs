namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class AudioType
    {
        public AudioType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfAudioClip { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string AudioClipBegin { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string AudioClipEnd { get; set; }
    }
}