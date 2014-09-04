using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class CohortType
    {
        public CohortType()
        {
            this.CategoryReference = new List<ReferenceType>();
            this.CodeReference = new List<ReferenceType>();
            this.Range = new List<RangeType>();
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 0)]
        public List<ReferenceType> CategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 1)]
        public List<ReferenceType> CodeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 2)]
        public List<RangeType> Range { get; set; }
    }
}