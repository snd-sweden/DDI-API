using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class AreaCoverageType
    {
        public AreaCoverageType()
        {
            
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfArea { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType MeasurementUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public Nullable<decimal> AreaMeasure { get; set; }

        public bool ShouldSerializeAreaMeasure()
        {
            return this.AreaMeasure.HasValue;
        }
    }
}