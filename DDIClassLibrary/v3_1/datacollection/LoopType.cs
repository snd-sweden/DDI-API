using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class LoopType : ControlConstructType
    {
        public LoopType()
        {
            this.ObjectType = "Loop";
            
            this.ControlConstructReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType LoopVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeType InitialValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeType LoopWhile { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeType StepValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> ControlConstructReference { get; set; }
    }
}