using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class OrganizationType : VersionableType
    {
        public OrganizationType()
        {
            this.ObjectType = "Organization";

            this.OrganizationName = new List<InternationalStringType>();
            this.Nickname = new List<InternationalStringType>();
            this.DDIMaintenanceAgencyID = new List<DDIMaintenanceAgencyIDType>();
            this.Description = new List<StructuredStringType>();
            this.Keyword = new List<InternationalStringType>();
            this.Location = new List<LocationType>();
            this.Telephone = new List<TelephoneType>();
            this.URL = new List<URLType>();
            this.Email = new List<EmailType>();
            this.InstantMessaging = new List<InstantMessagingType>();
            this.Note = new List<NoteType>();
            this.Individual = new List<IndividualType>();
            this.Relation = new List<RelationType>();
            this.Image = new List<ImageType>();
            this.VersionDistinction = new List<VersionDistinctionType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public List<InternationalStringType> OrganizationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Nickname { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DDIMaintenanceAgencyIDType> DDIMaintenanceAgencyID { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<InternationalStringType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<LocationType> Location { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<TelephoneType> Telephone { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<URLType> URL { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<EmailType> Email { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<InstantMessagingType> InstantMessaging { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public CodeValueType RegionalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 12)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<IndividualType> Individual { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<RelationType> Relation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 15)]
        public List<ImageType> Image { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<VersionDistinctionType> VersionDistinction { get; set; }
    }
}