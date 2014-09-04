using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicCoverageType : IdentifiableType
    {
        public GeographicCoverageType()
        {
            this.Description = new List<StructuredStringType>();
            this.Country = new List<CountryType> ();
            this.Country_2 = new List<Country_2Type>();
            this.Country_3 = new List<Country_3Type>();
            this.Country_N = new List<Country_NType>();
            this.GeographicStructureReference = new List<GeographicStructureReferenceType> ();
            this.GeographicLevelReference = new List<ReferenceType> ();
            this.GeographicLocationReference = new List<GeographicLocationReferenceType> ();
            this.LocationValueReference = new List<ReferenceType> ();
            this.SummaryDataReference = new List<ReferenceType> ();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public BoundingBoxType BoundingBox { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CountryType> Country { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<Country_2Type> Country_2 { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<Country_3Type> Country_3 { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<Country_NType> Country_N { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType GeographyStructureVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public GeographicDescriptionCodeType SpatialObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public List<GeographicStructureReferenceType> GeographicStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public List<ReferenceType> GeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public List<GeographicLocationReferenceType> GeographicLocationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public List<ReferenceType> LocationValueReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 12)]
        public List<ReferenceType> SummaryDataReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 13)]
        public LevelReferenceType TopLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 14)]
        public LevelReferenceType LowestLevelReference { get; set; }

    }
}