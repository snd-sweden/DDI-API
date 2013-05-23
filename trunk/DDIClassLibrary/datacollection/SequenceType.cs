using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class SequenceType : ControlConstructType
    {
        public SequenceType()
        {
            this.ObjectType = "Sequence";

            this.ControlConstructReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Type { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> ControlConstructReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public SpecificSequenceType ConstructSequence { get; set; }
    }
}