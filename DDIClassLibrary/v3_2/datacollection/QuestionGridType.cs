using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionGridType : VersionableType
    {
        public QuestionGridType()
        {
            this.QuestionGridName = new List<NameType>();
            this.InParameter = new List<InParameterType>();
            this.OutParameter = new List<ParameterType>();
            this.Binding = new List<BindingType>();
            this.QuestionText = new List<DynamicTextType>();
            this.GridDimension = new List<GridDimensionType>();
            this.CellLabel = new List<CellLabelType>();
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
        public List<NameType> QuestionGridName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<InParameterType> InParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<ParameterType> OutParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<BindingType> Binding { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<DynamicTextType> QuestionText { get; set; }
                
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public StructuredStringType QuestionIntent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<GridDimensionType> GridDimension { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public RepresentationType ResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public DomainReferenceType ResponseDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public StructuredMixedGridResponseDomainType StructuredMixedGridResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<CellLabelType> CellLabel { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 11)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<OtherMaterialType> ExternalAid { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<ExternalInterviewerInstructionType> ExternalInterviewerInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<InterviewerInstructionReferenceType> InterviewerInstructionReference { get; set; }        
    }
}