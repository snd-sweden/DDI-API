using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ComputationItemType : ControlConstructType
    {
        public ComputationItemType()
        {

        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CommandCodeType CommandCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType AssignedVariableReference { get; set; }
    }
}
