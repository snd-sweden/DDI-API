using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class QuestionConstructType : ControlConstructType
    {
        public QuestionConstructType()
        {
            this.ObjectType = "QuestionConstruct";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType QuestionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public SpecificSequenceType ResponseSequence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> ResponseUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<CodeValueType> AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<ReferenceType> UniverseReference { get; set; }
    }
}