using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DimensionRankValueType
    {
        public DimensionRankValueType()
        {

        }

        private Nullable<int> _rank;

        [System.Xml.Serialization.XmlAttribute()]
        public int rank
        {
            get
            {
                if (_rank.HasValue)
                    return _rank.Value;
                return 0; //default value;
            }
            set
            {
                this._rank = value;
            }
        }

        public bool ShouldSerializerank()
        {
            return _rank.HasValue;
        }
         
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Value { get; set; }

    }
}