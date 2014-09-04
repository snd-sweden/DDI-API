namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CoverageType
    {
        public CoverageType()
        {
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
    }
}