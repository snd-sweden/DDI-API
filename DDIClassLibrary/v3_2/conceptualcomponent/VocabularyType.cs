using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class VocabularyType
    {
        public VocabularyType()
        {
            this.Abbreviation = new List<InternationalStringType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.Comments = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public InternationalStringType VocabularyTitle { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<InternationalStringType> Abbreviation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement("XML-URI", Order = 5)]
        public string XMLURI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string Scheme { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string SchemeURI { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<StructuredStringType> Comments { get; set; }
    }
}