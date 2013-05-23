using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographyValueType
    {
        public GeographyValueType()
        {
            this.GeographyName = new List<InternationalStringType>();
            this.BoundingPolygon = new List<PolygonType>();
            this.ExcludingPolygon = new List<PolygonType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public GeographyCodeType GeographyCode { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> GeographyName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DateType GeographicTime { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PolygonType> BoundingPolygon { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<PolygonType> ExcludingPolygon { get; set; }
    }
}