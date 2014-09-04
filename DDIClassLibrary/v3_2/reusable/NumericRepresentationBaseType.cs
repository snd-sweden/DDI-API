using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NumericRepresentationBaseType : RepresentationType
    {
        public NumericRepresentationBaseType()
        {
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
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NumberRangeType> NumberRange { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType NumericTypeCode { get; set; }

    }
}