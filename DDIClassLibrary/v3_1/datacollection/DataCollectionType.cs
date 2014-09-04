using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class DataCollectionType : MaintainableType
    {
        public DataCollectionType()
        {
            this.ObjectType = "DataCollection";

            this.DataCollectionModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.CollectionEvent = new List<CollectionEventType>();
            this.QuestionScheme = new List<QuestionSchemeType>();
            this.ControlConstructScheme = new List<ControlConstructSchemeType>();
            this.InterviewerInstructionScheme = new List<InterviewerInstructionSchemeType>();
            this.Instrument = new List<InstrumentType>();
            this.ProcessingEvent = new List<ProcessingType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> DataCollectionModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 5)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public MethodologyType Methodology { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<CollectionEventType> CollectionEvent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<QuestionSchemeType> QuestionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ControlConstructSchemeType> ControlConstructScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<InterviewerInstructionSchemeType> InterviewerInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<InstrumentType> Instrument { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<ProcessingType> ProcessingEvent { get; set; }
    }
}