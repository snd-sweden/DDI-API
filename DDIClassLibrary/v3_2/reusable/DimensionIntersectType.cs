using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DimensionIntersectType : IHaveDefaultValues
    {
        public DimensionIntersectType()
        {
            this.IncludedDimension = new List<int>();
        }

        private Nullable<bool> _forAllDimensions;

        [System.Xml.Serialization.XmlAttribute()]
        public bool forAllDimensions
        {
            get
            {
                if (_forAllDimensions.HasValue)
                    return _forAllDimensions.Value;
                return true; //default value;
            }
            set
            {
                this._forAllDimensions = value;
            }
        }

        public bool ShouldSerializeforAllDimensions()
        {
            return _forAllDimensions.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string intersectValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<int> IncludedDimension { get; set; }

        public bool ShouldSerializeIncludedDimension()
        {
            return IncludedDimension.Count > 0;
        }

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!_forAllDimensions.HasValue) _forAllDimensions = true;
            }
        }
    }
}