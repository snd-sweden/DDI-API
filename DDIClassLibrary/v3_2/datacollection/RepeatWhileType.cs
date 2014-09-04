using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class RepeatWhileType : ControlConstructType
    {
        public RepeatWhileType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CommandCodeType WhileCondition { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType WhileConstructReference { get; set; }
    }
}