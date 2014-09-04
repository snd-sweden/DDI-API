using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.instance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:instance:3_2")]
    public class TranslationType
    {
        public TranslationType()
        {
            this.Language = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0, Namespace = "ddi:reusable:3_2")]
        public List<CodeValueType> Language { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public string I18n_text { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string I18n_catalog { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3, Namespace = "ddi:reusable:3_2")]
        public StructuredStringType Description { get; set; }
    }
}