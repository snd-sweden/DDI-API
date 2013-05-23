using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographicRepresentationType : RepresentationType
    {
        public GeographicRepresentationType()
        {
            this.CoordinatePairs = new List<CoordinatePairsType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public PointFormatType format { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public GeographicDescriptionCodeType spatialPrimitive { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "NCName", Order = 0)]
        public string Datum { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string CoordinateSystem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string CoordinateZone { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string CoordinateSource { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string ErrorCorrection { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string Offset { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string GeoreferencedObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string AddressMatchType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<CoordinatePairsType> CoordinatePairs { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public TextDomainType AlternateOffset { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public TextDomainType AlternateObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public TextDomainType AlternateCoordinateSystem { get; set; }
    }
}