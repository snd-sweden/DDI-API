using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class IndividualLanguageType
    {
        public IndividualLanguageType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CodeValueType Language { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType Read { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType Write { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType Speak { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public DateType EffectivePeriod { get; set; }
    }
}