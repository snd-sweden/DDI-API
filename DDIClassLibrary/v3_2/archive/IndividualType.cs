using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class IndividualType : VersionableType
    {
        public IndividualType()
        {
            this.Keyword = new List<InternationalCodeValueType>();
            this.RegionalCoverage = new List<CodeValueType>();
            this.AdditionalInformation = new List<AdditionalInformationType>();
            this.LanguageAbility = new List<IndividualLanguageType>();
            this.ContactInformation = new List<ContactInformationType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IndividualIdentificationType IndividualIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CodeValueType> RegionalCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<AdditionalInformationType> AdditionalInformation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<IndividualLanguageType> LanguageAbility { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ContactInformationType> ContactInformation { get; set; }

    }
}