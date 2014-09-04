using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ParentGeographicLevelReferenceType : ReferenceType
    {
        public ParentGeographicLevelReferenceType()
        {

        }

        private Nullable<bool> _isExhaustiveCoverage;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isExhaustiveCoverage
        {
            get
            {
                if (_isExhaustiveCoverage.HasValue)
                    return _isExhaustiveCoverage.Value;
                return false; //default value;
            }
            set
            {
                this._isExhaustiveCoverage = value;
            }
        }

        public bool ShouldSerializeisExhaustiveCoverage()
        {
            return _isExhaustiveCoverage.HasValue;
        }
    }
}