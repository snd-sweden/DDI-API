using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class SequenceType : ControlConstructType
    {
        public SequenceType()
        {
            this.TypeOfSequence = new List<CodeValueType>();
            this.ControlConstructReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<CodeValueType> TypeOfSequence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> ControlConstructReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public SpecificSequenceType ConstructSequence { get; set; }
    }
}