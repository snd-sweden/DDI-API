using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class IndividualType : VersionableType
    {
        public IndividualType()
        {
            this.ObjectType = "Individual";

            this.Nickname = new List<InternationalStringType>();
            this.DDIMaintenanceAgencyID = new List<DDIMaintenanceAgencyIDType>();
            this.ResearcherID = new List<ResearcherIDType>();
            this.Organization = new List<OrganizationType>();
            this.Position = new List<PositionType>();
            this.Description = new List<StructuredStringType>();
            this.Keyword = new List<InternationalStringType>();
            this.Location = new List<LocationType>();
            this.Telephone = new List<TelephoneType>();
            this.URL = new List<URLType>();
            this.Email = new List<EmailType>();
            this.InstantMessaging = new List<InstantMessagingType>();
            this.Language = new List<IndividualLanguageType>();
            this.Note = new List<NoteType>();
            this.Relation = new List<RelationType>();
            this.Image = new List<ImageType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IndividualNameType IndividualName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string DisplayName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Nickname { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DDIMaintenanceAgencyIDType> DDIMaintenanceAgencyID { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ResearcherIDType> ResearcherID { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<OrganizationType> Organization { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<PositionType> Position { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 7)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<InternationalStringType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<LocationType> Location { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<TelephoneType> Telephone { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<URLType> URL { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<EmailType> Email { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<InstantMessagingType> InstantMessaging { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<IndividualLanguageType> Language { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 15)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<RelationType> Relation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 17)]
        public List<ImageType> Image { get; set; }
    }
}