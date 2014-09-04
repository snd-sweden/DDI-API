using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ControlConstructSchemeType : MaintainableType
    {
        public ControlConstructSchemeType()
        {
            this.ControlConstructSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ControlConstructSchemeReference = new List<SchemeReferenceType>();
            this.ControlConstruct = new List<ControlConstructType>();
            this.ControlConstructReference = new List<ReferenceType>();
            this.ControlConstructGroup = new List<ControlConstructGroupType>();
            this.ControlConstructGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ControlConstructSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> ControlConstructSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement("ComputationItem", typeof(ComputationItemType), Order = 4)]
        [System.Xml.Serialization.XmlElement("IfThenElse", typeof(IfThenElseType), Order = 4)]
        [System.Xml.Serialization.XmlElement("Loop", typeof(LoopType), Order = 4)]
        [System.Xml.Serialization.XmlElement("QuestionConstruct", typeof(QuestionConstructType), Order = 4)]
        [System.Xml.Serialization.XmlElement("RepeatUntil", typeof(RepeatUntilType), Order = 4)]
        [System.Xml.Serialization.XmlElement("RepeatWhile", typeof(RepeatWhileType), Order = 4)]
        [System.Xml.Serialization.XmlElement("Sequence", typeof(SequenceType), Order = 4)]
        [System.Xml.Serialization.XmlElement("StatementItem", typeof(StatementItemType), Order = 4)]
        public List<ControlConstructType> ControlConstruct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> ControlConstructReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ControlConstructGroupType> ControlConstructGroup { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> ControlConstructGroupReference { get; set; }
    }
}