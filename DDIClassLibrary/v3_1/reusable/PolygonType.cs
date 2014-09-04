using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class PolygonType
    {
        public PolygonType()
        {
            this.Point = new List<PointType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string ExternalURI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string PolygonLinkCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string ShapeFileFormat { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PointType> Point { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public DateType GeographicTime { get; set; }
    }
}