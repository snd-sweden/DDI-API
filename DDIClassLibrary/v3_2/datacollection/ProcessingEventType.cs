using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ProcessingEventType : IdentifiableType
    {
        public ProcessingEventType()
        {
            this.ControlOperation = new List<OperationType>();
            this.CleaningOperation = new List<OperationType>();
            this.Weighting = new List<WeightingType>();
            this.WeightingReference = new List<ReferenceType>();
            this.DataAppraisalInformation = new List<DataAppraisalInformationType>();
            this.ProcessingInstructionReference = new List<ProcessingInstructionReferenceType>();
            this.QualityStatementReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<OperationType> ControlOperation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<OperationType> CleaningOperation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<WeightingType> Weighting { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> WeightingReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<DataAppraisalInformationType> DataAppraisalInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ProcessingInstructionReferenceType> ProcessingInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<ReferenceType> QualityStatementReference { get; set; }

    }
}