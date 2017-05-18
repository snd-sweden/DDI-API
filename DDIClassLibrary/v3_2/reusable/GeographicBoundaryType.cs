using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicBoundaryType
    {
        public GeographicBoundaryType()
        {

        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<AreaCoverageType> AreaCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public BoundingBoxType BoundingBox { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<PolygonType> BoundingPolygon { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PolygonType> ExcludingPolygon { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public Nullable<DateTime> GeographicTime { get; set; }

        public bool ShouldSerializeGeographicTime()
        {
            return GeographicTime.HasValue;
        }
    }
}