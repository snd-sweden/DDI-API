using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographicCoverageType : IdentifiableType
    {
        public GeographicCoverageType()
        {
            this.ObjectType = "SpatialCoverage";

            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public BoundingBoxType BoundingBox { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType GeographyStructureVariable { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public GeographicDescriptionCodeType SpatialObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType GeographicStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType GeographicLocationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType SummaryDataReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public LevelReferenceType TopLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public LevelReferenceType LowestLevelReference { get; set; }
    }
}