namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class LineParameterType
    {
        public LineParameterType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public int StartLine { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public int StartOffset { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public int EndLine { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public int EndOffset { get; set; }
    }
}