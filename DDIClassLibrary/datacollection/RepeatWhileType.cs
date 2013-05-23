using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class RepeatWhileType : ControlConstructType
    {
        public RepeatWhileType()
        {
            this.ObjectType = "RepeatWhile";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType WhileCondition { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType WhileConstructReference { get; set; }
    }
}