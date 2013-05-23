using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class PhysicalInstanceType : MaintainableType
    {
        public PhysicalInstanceType()
        {
            this.ObjectType = "PhysicalInstance";

            this.Fingerprint = new List<FingerprintType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.RecordLayoutReference = new List<ReferenceType>();
            this.DataFileIdentification = new List<DataFileIdentificationType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<FingerprintType> Fingerprint { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 2)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 5)]
        public List<ReferenceType> RecordLayoutReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 6)]
        public List<DataFileIdentificationType> DataFileIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public GrossFileStructureType GrossFileStructure { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 8)]
        public ProprietaryInfoType ProprietaryInfo { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public StatisticsType Statistics { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public CodeValueType ByteOrder { get; set; }
    }
}