using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class SpecificSequenceType
    {
        public SpecificSequenceType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ItemSequenceTypeType ItemSequenceType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CommandCodeType AlternateSequenceType { get; set; }
    }
}