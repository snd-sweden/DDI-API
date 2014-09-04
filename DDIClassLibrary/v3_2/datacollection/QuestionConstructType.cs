using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionConstructType : ControlConstructType
    {
        public QuestionConstructType()
        {
            this.AnalysisUnit = new List<CodeValueType>();
            this.UniverseReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType QuestionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public SpecificSequenceType ResponseSequence { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public SpecificSequenceType DimensionSequence { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType ResponseUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<CodeValueType> AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> UniverseReference { get; set; }
    }
}