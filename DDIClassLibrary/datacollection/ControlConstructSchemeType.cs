using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ControlConstructSchemeType : MaintainableType
    {
        public ControlConstructSchemeType()
        {
            this.ObjectType = "ControlConstructScheme"; 

            this.ControlConstructSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ControlConstructSchemeReference = new List<ReferenceType>();
            this.ControlConstruct = new List<ControlConstructType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ControlConstructSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> ControlConstructSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement("ComputationItem", typeof(ComputationItemType), Order = 4)]
        [System.Xml.Serialization.XmlElement("IfThenElse", typeof(IfThenElseType), Order = 4)]
        [System.Xml.Serialization.XmlElement("Loop", typeof(LoopType), Order = 4)]
        [System.Xml.Serialization.XmlElement("QuestionConstruct", typeof(QuestionConstructType), Order = 4)]
        [System.Xml.Serialization.XmlElement("RepeatUntil", typeof(RepeatUntilType), Order = 4)]
        [System.Xml.Serialization.XmlElement("RepeatWhile", typeof(RepeatWhileType), Order = 4)]
        [System.Xml.Serialization.XmlElement("Sequence", typeof(SequenceType), Order = 4)]
        [System.Xml.Serialization.XmlElement("StatementItem", typeof(StatementItemType), Order = 4)]
        public List<ControlConstructType> ControlConstruct { get; set; }
    }
}