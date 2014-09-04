using System;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class PhysicalLocationType
    {
        public PhysicalLocationType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType StorageFormat { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public DelimiterType Delimiter { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public Nullable<int> StartPosition { get; set; }

        public bool ShouldSerializeStartPosition()
        {
            return StartPosition.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public Nullable<int> ArrayPosition { get; set; }

        public bool ShouldSerializeArrayPosition()
        {
            return ArrayPosition.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public Nullable<int> EndPosition { get; set; }

        public bool ShouldSerializeEndPosition()
        {
            return EndPosition.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public Nullable<int> Width { get; set; }

        public bool ShouldSerializeWidth()
        {
            return Width.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public Nullable<int> DecimalPositions { get; set; }

        public bool ShouldSerializeDecimalPositions()
        {
            return DecimalPositions.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public OneCharStringType DecimalSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public OneCharStringType DigitGroupSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public string LanguageOfData { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public string LocaleOfData { get; set; }
    }
}