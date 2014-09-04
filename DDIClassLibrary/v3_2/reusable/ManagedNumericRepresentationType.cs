using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedNumericRepresentationType : VersionableType
    {
        public ManagedNumericRepresentationType()
        {
            this.ManagedNumericRepresentationName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.NumberRange = new List<NumberRangeType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string format { get; set; }

        private Nullable<int> _scale;

        [System.Xml.Serialization.XmlAttribute()]
        public int scale
        {
            get
            {
                if (_scale.HasValue)
                    return _scale.Value;
                return 0; //default value;
            }
            set
            {
                this._scale = value;
            }
        }

        public bool ShouldSerializescale()
        {
            return _scale.HasValue;
        }

        private Nullable<int> _decimalPositions;

        [System.Xml.Serialization.XmlAttribute()]
        public int decimalPositions
        {
            get
            {
                if (_decimalPositions.HasValue)
                    return _decimalPositions.Value;
                return 0; //default value;
            }
            set
            {
                this._decimalPositions = value;
            }
        }

        public bool ShouldSerializedecimalPositions()
        {
            return _decimalPositions.HasValue;
        }

        private Nullable<int> _interval;

        [System.Xml.Serialization.XmlAttribute()]
        public int interval
        {
            get
            {
                if (_interval.HasValue)
                    return _interval.Value;
                return 0; //default value;
            }
            set
            {
                this._interval = value;
            }
        }

        public bool ShouldSerializeinterval()
        {
            return _interval.HasValue;
        }

        private Nullable<CategoryRelationCodeType> _classificationLevel;

        [System.Xml.Serialization.XmlAttribute()]
        public CategoryRelationCodeType classificationLevel
        {
            get
            {
                if (_classificationLevel.HasValue)
                    return _classificationLevel.Value;
                return 0; //default value;
            }
            set
            {
                this._classificationLevel = value;
            }
        }

        public bool ShouldSerializeclassificationLevel()
        {
            return _classificationLevel.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ManagedNumericRepresentationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CodeValueType GenericOutputFormat { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<NumberRangeType> NumberRange { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CodeValueType NumericTypeCode { get; set; }
    }
}