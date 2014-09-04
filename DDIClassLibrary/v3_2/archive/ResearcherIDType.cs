using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class ResearcherIDType
    {
        public ResearcherIDType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string ResearcherIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }
      
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public DateType EffectivePeriod { get; set; }

    }
}