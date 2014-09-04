using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicLocationType : VersionableType
    {
        public GeographicLocationType()
        {
            this.GeographicLocationName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.AuthorizedSource = new List<AuthorizedSourceType>();
            this.LocationValue = new List<LocationValueType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> GeographicLocationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType GeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredStringType GeographicLevelDescription { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<AuthorizedSourceType> AuthorizedSource { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<LocationValueType> LocationValue { get; set; }

    }
}