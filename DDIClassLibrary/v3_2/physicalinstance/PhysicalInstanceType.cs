using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class PhysicalInstanceType : MaintainableType
    {
        public PhysicalInstanceType()
        {
            this.DataFingerprint = new List<DataFingerprintType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.DataRelationshipReference = new List<ReferenceType>();
            this.RecordLayoutReference = new List<ReferenceType>();
            this.DataFileIdentification = new List<DataFileIdentificationType>();
            this.QualityStatementReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DataFingerprintType> DataFingerprint { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ReferenceType> DataRelationshipReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> RecordLayoutReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public DefaultMissingValuesReferenceType DefaultMissingValuesReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<DataFileIdentificationType> DataFileIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public DataFileVersionType DataFileVersion { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 9)]
        public List<ReferenceType> QualityStatementReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public GrossFileStructureType GrossFileStructure { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 11)]
        public ProprietaryInfoType ProprietaryInfo { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 12)]
        public StatisticalSummaryType StatisticalSummary { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 13)]
        public CodeValueType ByteOrder { get; set; }

    }
}