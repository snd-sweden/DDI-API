using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class MultipleQuestionItemType : VersionableType
    {
        public MultipleQuestionItemType()
        {
            this.ObjectType = "MultipleQuestionItem";

            this.MultipleQuestionItemName = new List<NameType>();
            this.QuestionText = new List<DynamicTextType>();
            this.QuestionIntent = new List<StructuredStringType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ExternalAid = new List<OtherMaterialType>();
            this.SubQuestions = new QuestionGroupType();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> MultipleQuestionItemName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DynamicTextType> QuestionText { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> QuestionIntent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<OtherMaterialType> ExternalAid { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public SpecificSequenceType SubQuestionSequence { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public QuestionGroupType SubQuestions { get; set; }
    }
}