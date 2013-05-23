using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class RepeatUntilType : ControlConstructType
    {
        public RepeatUntilType()
        {
            this.ObjectType = "RepeatUntil";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType UntilCondition { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType UntilConstructReference { get; set; }
    }
}