using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ElseIfType
    {
        public ElseIfType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType IfCondition { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType ThenConstructReference { get; set; }
    }
}