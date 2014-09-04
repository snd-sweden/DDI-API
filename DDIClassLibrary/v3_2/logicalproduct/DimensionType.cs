using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class DimensionType
    {
        public DimensionType()
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType VariableReference { get; set; }
    }
}