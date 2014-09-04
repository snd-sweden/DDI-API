using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class GridResponseDomainType
    {
        public GridResponseDomainType()
        {
            this.ResponseDomain = new List<RepresentationType>();
            this.DateTimeDomainReference = new List<DomainReferenceType>();
            this.MissingValuesDomainReference = new List<DomainReferenceType>();
            this.NumericDomainReference = new List<DomainReferenceType>();
            this.ScaleDomainReference = new List<DomainReferenceType>();
            this.TextDomainReference = new List<DomainReferenceType>();
            this.GridAttachment = new List<GridAttachmentType>();
        }

        [System.Xml.Serialization.XmlElement("CategoryDomain", typeof(CategoryDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("CodeDomain", typeof(CodeDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("DateTimeDomain", typeof(DateTimeDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("DistributionDomain", typeof(DistributionDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("GeographicDomain", typeof(GeographicDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("GeographicLocationCodeDomain", typeof(GeographicLocationCodeDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("GeographicStructureCodeDomain", typeof(GeographicStructureCodeDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("LocationDomain", typeof(LocationDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("NominalDomain", typeof(NominalDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("NumericDomain", typeof(NumericDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("RankingDomain", typeof(RankingDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("ScaleDomain", typeof(ScaleDomainType), Order = 0)]
        [System.Xml.Serialization.XmlElement("TextDomain", typeof(TextDomainType), Order = 0)]
        public List<RepresentationType> ResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DomainReferenceType> DateTimeDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<DomainReferenceType> MissingValuesDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DomainReferenceType> NumericDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<DomainReferenceType> ScaleDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<DomainReferenceType> TextDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<GridAttachmentType> GridAttachment { get; set; }

    }
}