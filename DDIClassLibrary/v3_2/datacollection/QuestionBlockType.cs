using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionBlockType : VersionableType
    {
        public QuestionBlockType()
        {
            this.QuestionBlockName = new List<NameType>();
            this.InParameter = new List<InParameterType>();
            this.OutParameter = new List<ParameterType>();
            this.Binding = new List<BindingType>();
            this.StimulusMaterial = new List<OtherMaterialType>();
            this.QuestionItemReference = new List<ReferenceType>();
            this.QuestionBlockReference = new List<ReferenceType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ExternalAid = new List<OtherMaterialType>();
            this.ExternalInterviewerInstruction = new List<ExternalInterviewerInstructionType>();
            this.InterviewerInstructionReference = new List<InterviewerInstructionReferenceType>();
        }

        private Nullable<decimal> _estimatedSecondsResponseTime;

        [System.Xml.Serialization.XmlAttribute()]
        public decimal estimatedSecondsResponseTime
        {
            get
            {
                if (_estimatedSecondsResponseTime.HasValue)
                    return _estimatedSecondsResponseTime.Value;
                return 0; //default value;
            }
            set
            {
                this._estimatedSecondsResponseTime = value;
            }
        }

        public bool ShouldSerializeestimatedSecondsResponseTime()
        {
            return _estimatedSecondsResponseTime.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QuestionBlockName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<InParameterType> InParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<ParameterType> OutParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<BindingType> Binding { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredStringType QuestionBlockIntent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<OtherMaterialType> StimulusMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> QuestionItemReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> QuestionBlockReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public QuestionSequenceType QuestionSequence { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public ResponseCardinalityType ResponseCardinality { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 10)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<OtherMaterialType> ExternalAid { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<ExternalInterviewerInstructionType> ExternalInterviewerInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<InterviewerInstructionReferenceType> InterviewerInstructionReference { get; set; }        
    }
}