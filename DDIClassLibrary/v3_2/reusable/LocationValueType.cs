using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LocationValueType : IdentifiableType
    {
        public LocationValueType()
        {
            this.LocationValueName = new List<NameType>();
            this.GeographicLocationIdentifier = new List<GeographicLocationIdentifierType>();
            this.DefiningCharacteristic = new List<DefiningCharacteristicType>();
            this.GeographicBoundary = new List<GeographicBoundaryType>();
            this.SupersedesLocationValue = new List<RelatedLocationValueReferenceType>();
            this.PrecedesLocationValue = new List<RelatedLocationValueReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> LocationValueName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<GeographicLocationIdentifierType> GeographicLocationIdentifier { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<DefiningCharacteristicType> DefiningCharacteristic { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public Nullable<DateTime> GeographicTime { get; set; }

        public bool ShouldSerializeGeographicTime()
        {
            return GeographicTime.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<GeographicBoundaryType> GeographicBoundary { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<RelatedLocationValueReferenceType> SupersedesLocationValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<RelatedLocationValueReferenceType> PrecedesLocationValue { get; set; }
    }
}