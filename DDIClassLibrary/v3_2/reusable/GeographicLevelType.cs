using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicLevelType : IdentifiableType
    {
        public GeographicLevelType()
        {
            this.GeographicLevelName = new List<NameType>();
            this.GeographicLevelCode = new List<CodeValueType>();
            this.PrimaryComponentLevel = new List<PrimaryComponentLevelType>();
            this.ParentGeographicLevelReference = new List<ParentGeographicLevelReferenceType>();
            this.GeographicLayerBaseReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> GeographicLevelName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public List<CodeValueType> GeographicLevelCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public InternationalStringType CoverageLimitation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public List<PrimaryComponentLevelType> PrimaryComponentLevel { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public List<ParentGeographicLevelReferenceType> ParentGeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public List<ReferenceType> GeographicLayerBaseReference { get; set; }
        
    }
}