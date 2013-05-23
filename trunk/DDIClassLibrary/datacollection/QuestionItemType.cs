using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class QuestionItemType : VersionableType
    {
        public QuestionItemType()
        {
            this.ObjectType = "QuestionItem";

            this.QuestionItemName = new List<NameType>();
            this.QuestionText = new List<DynamicTextType>();
            this.QuestionIntent = new List<StructuredStringType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ExternalAid = new List<OtherMaterialType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QuestionItemName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DynamicTextType> QuestionText { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> QuestionIntent { get; set; }

        [System.Xml.Serialization.XmlElement("CategoryDomain", typeof(CategoryDomainType), Order = 3)]
        [System.Xml.Serialization.XmlElement("CodeDomain", typeof(CodeDomainType), Order = 3)]
        [System.Xml.Serialization.XmlElement("DateTimeDomain", typeof(DateTimeDomainType), Order = 3)]
        [System.Xml.Serialization.XmlElement("GeographicDomain", typeof(GeographicDomainType), Order = 3)]
        [System.Xml.Serialization.XmlElement("NumericDomain", typeof(NumericDomainType), Order = 3)]
        [System.Xml.Serialization.XmlElement("ResponseDomain", typeof(RepresentationType), Order = 3)]
        [System.Xml.Serialization.XmlElement("TextDomain", typeof(TextDomainType), Order = 3)]
        public RepresentationType ResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredMixedResponseDomainType StructuredMixedResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<OtherMaterialType> ExternalAid { get; set; }
    }
}