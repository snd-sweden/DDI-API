using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ProcessingInstructionSchemeType : MaintainableType
    {
        public ProcessingInstructionSchemeType()
        {
            this.ProcessingInstructionSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ProcessingInstructionSchemeReference = new List<SchemeReferenceType>();
            this.GeneralInstruction = new List<GeneralInstructionType>();
            this.GeneralInstructionReference = new List<ReferenceType>();
            this.GenerationInstruction = new List<GenerationInstructionType>();
            this.GenerationInstructionReference = new List<ReferenceType>();
            this.ProcessingInstructionGroup = new List<ProcessingInstructionGroupType>();
            this.ProcessingInstructionGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ProcessingInstructionSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> ProcessingInstructionSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<GeneralInstructionType> GeneralInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> GeneralInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<GenerationInstructionType> GenerationInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> GenerationInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ProcessingInstructionGroupType> ProcessingInstructionGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> ProcessingInstructionGroupReference { get; set; }
    }
}