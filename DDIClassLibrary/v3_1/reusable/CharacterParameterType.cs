namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CharacterParameterType
    {
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public int StartCharOffset { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public int EndCharOffset { get; set; }
    }
}