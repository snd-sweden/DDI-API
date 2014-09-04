using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class PhysicalStructureType : VersionableType
    {
        public PhysicalStructureType()
        {
            this.GrossRecordStructure = new List<GrossRecordStructureType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType FileFormat { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public CodeValueType DefaultDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public DelimiterType DefaultDelimiter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public Nullable<int> DefaultDecimalPositions { get; set; }

        public bool ShouldSerializeDefaultDecimalPositions()
        {
            return DefaultDecimalPositions.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public OneCharStringType DefaultDecimalSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public OneCharStringType DefaultDigitGroupSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<GrossRecordStructureType> GrossRecordStructure { get; set; }
    }
}