using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class LocationType : IdentifiableType
    {
        public LocationType()
        {
            this.ObjectType = "Location";

            this.Nickname = new List<InternationalStringType>();
            this.Address = new List<AddressType>();
            this.Telephone = new List<TelephoneType>();
            this.URL = new List<URLType>();
            this.Email = new List<EmailType>();
            this.InstantMessaging = new List<InstantMessagingType>();
            this.Note = new List<string>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType LocationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public NameType LocationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Nickname { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<AddressType> Address { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CountryType Country { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<TelephoneType> Telephone { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<URLType> URL { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<EmailType> Email { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<InstantMessagingType> InstantMessaging { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public PointType GeographicLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public CodeValueType RegionalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 11)]
        public string TimeZone { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<string> Note { get; set; }
    }
}