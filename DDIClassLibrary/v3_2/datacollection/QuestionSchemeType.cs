using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionSchemeType : MaintainableType
    {
        public QuestionSchemeType()
        {
            this.QuestionSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.QuestionSchemeReference = new List<SchemeReferenceType>();
            this.QuestionItem = new List<QuestionItemType>();
            this.QuestionItemReference = new List<ReferenceType>();
            this.QuestionGrid = new List<QuestionGridType>();
            this.QuestionGridReference = new List<ReferenceType>();
            this.QuestionBlock = new List<QuestionBlockType>();
            this.QuestionBlockReference = new List<ReferenceType>();
            this.QuestionGroup = new List<QuestionGroupType>();
            this.QuestionGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QuestionSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> QuestionSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<QuestionItemType> QuestionItem { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> QuestionItemReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<QuestionGridType> QuestionGrid { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> QuestionGridReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<QuestionBlockType> QuestionBlock { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> QuestionBlockReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<QuestionGroupType> QuestionGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> QuestionGroupReference { get; set; }
    }
}