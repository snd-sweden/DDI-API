using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DistributionRepresentationBaseType : RepresentationType
    {
        public DistributionRepresentationBaseType()
        {

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

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public decimal DistributionValue { get; set; }
    }
}