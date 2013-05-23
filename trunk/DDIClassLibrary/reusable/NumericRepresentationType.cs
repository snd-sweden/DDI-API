using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class NumericRepresentationType : RepresentationType
    {
        public NumericRepresentationType()
        {
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NumberRangeType> NumberRange { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public NumericTypeCodeType type { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public int decimalPositions { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public double startValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public double endValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public double interval { get; set; }
    }
}