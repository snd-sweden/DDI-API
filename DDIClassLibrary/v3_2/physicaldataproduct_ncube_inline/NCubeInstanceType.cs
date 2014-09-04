using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_2")]
    public class NCubeInstanceType : VersionableType
    {
        public NCubeInstanceType()
        {
            this.AttachedAttribute = new List<AttachedAttributeType>();
            this.DataItem = new List<DataItemType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType NCubeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public MeasureDimensionType MeasureDimension { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<AttachedAttributeType> AttachedAttribute { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DataItemType> DataItem { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public CodeValueType DefaultDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public DelimiterType DefaultDelimiter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public Nullable<int> DefaultDecimalPositions { get; set; }

        public bool ShouldSerializeDefaultDecimalPositions()
        {
            return DefaultDecimalPositions.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public OneCharStringType DefaultDecimalSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 8)]
        public OneCharStringType DefaultDigitGroupSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public Nullable<int> NumberOfCases { get; set; }

        public bool ShouldSerializeNumberOfCases()
        {
            return NumberOfCases.HasValue;
        }
    }
}