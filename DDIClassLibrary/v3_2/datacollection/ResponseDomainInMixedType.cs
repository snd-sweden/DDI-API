using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ResponseDomainInMixedType
    {
        public ResponseDomainInMixedType()
        {

        }

        private Nullable<int> _attachmentBase;

        [System.Xml.Serialization.XmlAttribute()]
        public int attachmentBase
        {
            get
            {
                if (_attachmentBase.HasValue)
                    return _attachmentBase.Value;
                return 0; //default value;
            }
            set
            {
                this._attachmentBase = value;
            }
        }

        public bool ShouldSerializeattachmentBase()
        {
            return _attachmentBase.HasValue;
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
        public RepresentationType ResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public DomainReferenceType DateTimeDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DomainReferenceType MissingValuesDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public DomainReferenceType NumericDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public DomainReferenceType ScaleDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public DomainReferenceType TextDomainReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public AttachmentLocationType AttachmentLocation { get; set; }
    }
}