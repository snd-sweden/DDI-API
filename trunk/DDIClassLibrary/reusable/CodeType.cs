using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CodeType
    {
        public CodeType()
        {
            this.Code = new List<ProgrammingLanguageCodeType>();
            this.SourceQuestionReference = new List<ReferenceType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<ProgrammingLanguageCodeType> Code { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> SourceQuestionReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }
    }
}