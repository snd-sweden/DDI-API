using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class LoopType : ControlConstructType
    {
        public LoopType()
        {
            this.ControlConstructReference = new List<ControlConstructReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType LoopVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CommandCodeType InitialValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CommandCodeType LoopWhile { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CommandCodeType StepValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ControlConstructReferenceType> ControlConstructReference { get; set; }
    }
}