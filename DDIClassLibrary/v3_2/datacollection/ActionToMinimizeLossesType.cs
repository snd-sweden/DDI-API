using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ActionToMinimizeLossesType : IdentifiableType
    {
        public ActionToMinimizeLossesType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfActionToMinimizeLosses { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Description { get; set; }
    }
}