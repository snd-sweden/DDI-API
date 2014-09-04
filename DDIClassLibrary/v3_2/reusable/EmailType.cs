using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class EmailType
    {
        public EmailType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public InternetEmailType InternetEmail { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType EmailTypeCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DateType EffectivePeriod { get; set; }
    }
}