using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class VocabularyType
    {
        public VocabularyType()
        {
            this.Title = new List<InternationalStringType>();
            this.Abbreviation = new List<InternationalStringType>();
            this.Keyword = new List<InternationalStringType>();
            this.Description = new List<StructuredStringType>();
            this.Comments = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> Title { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> Abbreviation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 4)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement("XML-URI", DataType = "anyURI", Order = 5)]
        public string XMLURI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string Scheme { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 7)]
        public string SchemeURI { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<StructuredStringType> Comments { get; set; }
    }
}