using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class QuestionGroupType
    {
        public QuestionGroupType()
        {
            this.QuestionItem = new List<QuestionItemType>();
            this.MultipleQuestionItem = new List<MultipleQuestionItemType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<QuestionItemType> QuestionItem { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<MultipleQuestionItemType> MultipleQuestionItem { get; set; }
    }
}