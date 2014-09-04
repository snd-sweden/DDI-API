using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ResponseRateType
    {
        public ResponseRateType()
        {

        }
                
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<int> SampleSize { get; set; }

        public bool ShouldSerializeSampleSize()
        {
            return SampleSize.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> NumberOfResponses { get; set; }

        public bool ShouldSerializeNumberOfResponses()
        {
            return NumberOfResponses.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public Nullable<decimal> SpecificResponseRate { get; set; }

        public bool ShouldSerializeSpecificResponseRate()
        {
            return SpecificResponseRate.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }
    }
}