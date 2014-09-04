using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LabelType : StructuredStringType
    {
        public LabelType()
        {
        }

        public LabelType(string content, string lang)
            : base (content, lang)
        {            
        }


        [System.Xml.Serialization.XmlAttribute()]
        public string locationVariant { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string validForStartDate { get; set; }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string validForEndDate { get; set; }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string maxLength { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfLabel { get; set; }
    }
}