using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ConditionalTextType : TextType
    {
        public ConditionalTextType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType Expression { get; set; }
    }
}