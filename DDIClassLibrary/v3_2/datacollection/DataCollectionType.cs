using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class DataCollectionType : MaintainableType
    {
        public DataCollectionType()
        {
            this.DataCollectionModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.CollectionEvent = new List<CollectionEventType>();
            this.QuestionScheme = new List<QuestionSchemeType>();
            this.QuestionSchemeReference = new List<SchemeReferenceType>();
            this.ControlConstructScheme = new List<ControlConstructSchemeType>();
            this.ControlConstructSchemeReference = new List<SchemeReferenceType>();
            this.InterviewerInstructionScheme = new List<InterviewerInstructionSchemeType>();
            this.InterviewerInstructionSchemeReference = new List<SchemeReferenceType>();
            this.InstrumentScheme = new List<InstrumentSchemeType>();
            this.InstrumentSchemeReference = new List<SchemeReferenceType>();
            this.ProcessingEventScheme = new List<ProcessingEventSchemeType>();
            this.ProcessingEventSchemeReference = new List<SchemeReferenceType>();
            this.ProcessingInstructionScheme = new List<ProcessingInstructionSchemeType>();
            this.ProcessingInstructionSchemeReference = new List<SchemeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> DataCollectionModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<OtherMaterialType> OtherMaterial { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public MethodologyType Methodology { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType MethodologyReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<CollectionEventType> CollectionEvent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<QuestionSchemeType> QuestionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 9)]
        public List<SchemeReferenceType> QuestionSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ControlConstructSchemeType> ControlConstructScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 11)]
        public List<SchemeReferenceType> ControlConstructSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<InterviewerInstructionSchemeType> InterviewerInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 13)]
        public List<SchemeReferenceType> InterviewerInstructionSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<InstrumentSchemeType> InstrumentScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 15)]
        public List<SchemeReferenceType> InstrumentSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ProcessingEventSchemeType> ProcessingEventScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 17)]
        public List<SchemeReferenceType> ProcessingEventSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 18)]
        public List<ProcessingInstructionSchemeType> ProcessingInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 19)]
        public List<SchemeReferenceType> ProcessingInstructionSchemeReference { get; set; }

    }
}