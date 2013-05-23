using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographicLocationType : VersionableType
    {
        public GeographicLocationType()
        {
            this.ObjectType = "GeographicLocation";

            this.Values = new List<GeographyValuesType>();
            this.GeographicLocationReference = new List<ReferenceType>();
            this.GeographicLevelDescription = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<GeographyValuesType> Values { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> GeographicLocationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType AuthorityOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType GeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<StructuredStringType> GeographicLevelDescription { get; set; }
    }
}