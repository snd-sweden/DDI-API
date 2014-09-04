using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class MetadataQualityType
    {
        public MetadataQualityType()
        {

        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public CodeValueType TypeOfMetadataQuality { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType MeasurePurpose { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType MeasureValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType Description { get; set; }

    }
}