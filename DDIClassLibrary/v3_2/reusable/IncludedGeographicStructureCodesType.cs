using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class IncludedGeographicStructureCodesType
    {
        public IncludedGeographicStructureCodesType()
        {
            this.ExcludedGeographicLevelReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType AuthorizedSourceReference { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public GeographicStructureReferenceType GeographicStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ReferenceType> ExcludedGeographicLevelReference { get; set; }
    }
}