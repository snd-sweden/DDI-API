using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionItemType : VersionableType
    {
        public QuestionItemType()
        {
            this.QuestionItemName = new List<NameType>();
            this.InParameter = new List<InParameterType>();
            this.OutParameter = new List<ParameterType>();
            this.Binding = new List<BindingType>();
            this.QuestionText = new List<DynamicTextType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ExternalAid = new List<OtherMaterialType>();
            this.ExternalInterviewerInstruction = new List<ExternalInterviewerInstructionType>();
            this.InterviewerInstructionReference = new List<InterviewerInstructionReferenceType>();

        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QuestionItemName { get; set; }

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

        [System.Xml.Serialization.XmlElement("CategoryDomain", typeof(CategoryDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("CodeDomain", typeof(CodeDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("DateTimeDomain", typeof(DateTimeDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("DistributionDomain", typeof(DistributionDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("GeographicDomain", typeof(GeographicDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("GeographicLocationCodeDomain", typeof(GeographicLocationCodeDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("GeographicStructureCodeDomain", typeof(GeographicStructureCodeDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("LocationDomain", typeof(LocationDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("NominalDomain", typeof(NominalDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("NumericDomain", typeof(NumericDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("RankingDomain", typeof(RankingDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("ScaleDomain", typeof(ScaleDomainType), Order = 6)]
        [System.Xml.Serialization.XmlElement("TextDomain", typeof(TextDomainType), Order = 6)]
        public RepresentationType ResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public DomainReferenceType DateTimeDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public DomainReferenceType MissingValuesDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public DomainReferenceType NumericDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public DomainReferenceType ScaleDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public DomainReferenceType TextDomainReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 12)]
        public StructuredMixedResponseDomainType StructuredMixedResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 13)]
        public ResponseCardinalityType ResponseCardinality { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 14)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 15)]
        public List<OtherMaterialType> ExternalAid { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ExternalInterviewerInstructionType> ExternalInterviewerInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 17)]
        public List<InterviewerInstructionReferenceType> InterviewerInstructionReference { get; set; }       

    }
}