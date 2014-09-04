using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ScaleDimensionType : IHaveDefaultValues
    {
        public ScaleDimensionType()
        {
            this.Label = new List<LabelType>();
            this.Anchor = new List<AnchorType>();
        }

        private Nullable<int> _dimensionNumber;

        [System.Xml.Serialization.XmlAttribute()]
        public int dimensionNumber
        {
            get
            {
                if (_dimensionNumber.HasValue)
                    return _dimensionNumber.Value;
                return 1; //default value;
            }
            set
            {
                this._dimensionNumber = value;
            }
        }

        public bool ShouldSerializedimensionNumber()
        {
            return _dimensionNumber.HasValue;
        }

        private Nullable<int> _degreeSlopeFromHorizontal;

        [System.Xml.Serialization.XmlAttribute()]
        public int degreeSlopeFromHorizontal
        {
            get
            {
                if (_degreeSlopeFromHorizontal.HasValue)
                    return _degreeSlopeFromHorizontal.Value;
                return 0; //default value;
            }
            set
            {
                this._degreeSlopeFromHorizontal = value;
            }
        }

        public bool ShouldSerializedegreeSlopeFromHorizontal()
        {
            return _degreeSlopeFromHorizontal.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public NumberRangeType NumberRange { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public RangeType Range { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<AnchorType> Anchor { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public BasicIncrementType MarkedIncrement { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public BasicIncrementType ValueIncrement { get; set; }

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!_dimensionNumber.HasValue) _dimensionNumber = 1;
                if (!_degreeSlopeFromHorizontal.HasValue) _degreeSlopeFromHorizontal = 0;
            }
        }
    }
}