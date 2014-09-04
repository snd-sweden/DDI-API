using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ComputationItemType : ControlConstructType
    {
        public ComputationItemType()
        {
            this.ObjectType = "ComputationItem";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType Code { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType AssignedVariableReference { get; set; }
    }
}