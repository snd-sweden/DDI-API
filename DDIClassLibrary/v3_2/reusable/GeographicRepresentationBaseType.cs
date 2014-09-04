using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicRepresentationBaseType : RepresentationType
    {
        public GeographicRepresentationBaseType()
        {
            this.CoordinatePairs = new List<CoordinatePairsType>();
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public PointFormatType pointFormat { get; set; }
        
        [System.Xml.Serialization.XmlAttribute()]
        public GeographicDescriptionCodeType spatialPrimitive { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Datum { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType CoordinateSystem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType CoordinateZone { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType CoordinateSource { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CodeValueType ErrorCorrection { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string Offset { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CodeValueType GeoreferencedObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public CodeValueType AddressMatchType { get; set; }

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