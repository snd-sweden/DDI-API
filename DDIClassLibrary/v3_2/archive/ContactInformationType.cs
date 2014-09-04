using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class ContactInformationType
    {
        public ContactInformationType()
        {
            this.LocationName = new List<LocationNameType>();
            this.Address = new List<AddressType>();
            this.Telephone = new List<TelephoneType>();
            this.URL = new List<URLType>();
            this.Email = new List<EmailType>();
            this.InstantMessaging = new List<InstantMessagingType>();
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LocationNameType> LocationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<AddressType> Address { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<TelephoneType> Telephone { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<URLType> URL { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<EmailType> Email { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<InstantMessagingType> InstantMessaging { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CodeValueType RegionalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public CodeValueType TypeOfLocation { get; set; }
    }
}