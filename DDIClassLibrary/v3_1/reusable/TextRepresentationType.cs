namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class TextRepresentationType : RepresentationType
    {
        public TextRepresentationType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int maxLength { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public int minLength { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public int regExp { get; set; }
    }
}