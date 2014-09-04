using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InterviewerInstructionSchemeType : MaintainableType
    {
        public InterviewerInstructionSchemeType()
        {
            this.InterviewerInstructionSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.InterviewerInstructionSchemeReference = new List<SchemeReferenceType>();
            this.Instruction = new List<InstructionType>();
            this.InstructionReference = new List<ReferenceType>();
            this.InstructionGroup = new List<InstructionGroupType>();
            this.InstructionGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> InterviewerInstructionSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> InterviewerInstructionSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<InstructionType> Instruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> InstructionReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<InstructionGroupType> InstructionGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> InstructionGroupReference { get; set; }
    }
}