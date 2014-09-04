using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class AdditionalInformationType : StructuredStringType
    {
        public AdditionalInformationType()
        {

        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public DateType EffectivePeriod { get; set; }
    }
}