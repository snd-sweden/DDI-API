using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographyType : IdentifiableType
    {
        public GeographyType()
        {
            this.ObjectType = "Geography";

            this.GeographicLayerBase = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public GeographicLevelType Level { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ParentGeographyType ParentGeography { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ReferenceType> GeographicLayerBase { get; set; }
    }
}