using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class LiteralTextType : TextContentType
    {
        public LiteralTextType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public TextType Text { get; set; }
    }
}