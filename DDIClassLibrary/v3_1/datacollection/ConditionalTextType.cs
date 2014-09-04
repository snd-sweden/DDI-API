using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
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