using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public abstract class ControlConstructType : VersionableType
    {
        public ControlConstructType()
        {
            this.ObjectType = "ControlConstruct";

            this.ContructName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ExternalAid = new List<OtherMaterialType>();
            this.ExternalInterviewerInstructionReference = new List<ExternalInterviewerInstructionReferenceType>();
            this.InterviewerInstructionReference = new List<InterviewerInstructionReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ContructName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<OtherMaterialType> ExternalAid { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ExternalInterviewerInstructionReferenceType> ExternalInterviewerInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<InterviewerInstructionReferenceType> InterviewerInstructionReference { get; set; }
    }
}