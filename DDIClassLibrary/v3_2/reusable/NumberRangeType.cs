using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NumberRangeType
    {
        public NumberRangeType()
        {
            this.Label = new List<LabelType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string regExp { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public NumberRangeValueType Low { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DoubleNumberRangeValueType LowDouble { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public NumberRangeValueType High { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public DoubleNumberRangeValueType HighDouble { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public Nullable<decimal> TopCode { get; set; }

        public bool ShouldSerializeTopCode()
        {
            return TopCode.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public Nullable<double> TopCodeDouble { get; set; }

        public bool ShouldSerializeTopCodeDouble()
        {
            return TopCodeDouble.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public Nullable<decimal> BottomCode { get; set; }

        public bool ShouldSerializeBottomCode()
        {
            return BottomCode.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public Nullable<double> BottomCodeDouble { get; set; }

        public bool ShouldSerializeBottomCodeDouble()
        {
            return BottomCodeDouble.HasValue;
        }
    }
}