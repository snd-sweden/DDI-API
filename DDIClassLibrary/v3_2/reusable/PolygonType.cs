using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
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
        public CodeValueType ShapeFileFormat { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PointType> Point { get; set; }
    }
}