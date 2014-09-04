using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class PhysicalStructureType : VersionableType
    {
        public PhysicalStructureType()
        {
            this.ObjectType = "PhysicalStructure";

            this.LogicalProductReference = new List<ReferenceType>();
            this.GrossRecordStructure = new List<GrossRecordStructureType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<ReferenceType> LogicalProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Format { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string DefaultDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string DefaultDelimiter { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public Nullable<int> DefaultDecimalPositions { get; set; }

        public bool ShouldSerializeDefaultDecimalPositions()
        {
            return DefaultDecimalPositions.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public OneCharStringType DefaultDecimalSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public OneCharStringType DefaultDigitGroupSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string DefaultMissingData { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 8)]
        public List<GrossRecordStructureType> GrossRecordStructure { get; set; }
    }
}