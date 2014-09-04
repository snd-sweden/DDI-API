using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographicLevelType
    {
        public GeographicLevelType()
        {
            this.Name = new List<InternationalStringType>();
            this.CoverageLimitation = new List<InternationalStringType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Code { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType AuthorityOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Name { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<InternationalStringType> CoverageLimitation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<StructuredStringType> Description { get; set; }
    }
}