using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographicStructureType : VersionableType
    {
        public GeographicStructureType()
        {
            this.ObjectType = "GeographicStructure";

            this.Geography = new List<GeographyType>();
            this.GeographyReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<GeographyType> Geography { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> GeographyReference { get; set; }
    }
}