using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CoverageType
    {
        public CoverageType()
        {
        }

        private Nullable<bool> _isRestrictionOfParentCoverage;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isRestrictionOfParentCoverage
        {
            get
            {
                if (_isRestrictionOfParentCoverage.HasValue)
                    return _isRestrictionOfParentCoverage.Value;
                return false; //default value;
            }
            set
            {
                this._isRestrictionOfParentCoverage = value;
            }
        }

        public bool ShouldSerializeisRestrictionOfParentCoverage()
        {
            return _isRestrictionOfParentCoverage.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType TopicalCoverageReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public TopicalCoverageType TopicalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType SpatialCoverageReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public GeographicCoverageType SpatialCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType TemporalCoverageReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public TemporalCoverageType TemporalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public RestrictionProcessType RestrictionProcess { get; set; }
    }
}