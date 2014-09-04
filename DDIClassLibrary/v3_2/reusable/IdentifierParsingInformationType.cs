using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class IdentifierParsingInformationType
    {
        public IdentifierParsingInformationType()
        {
            this.ParentIdentificationPortion = new List<IdentificationPortionType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string arrayBase { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<IdentificationPortionType> ParentIdentificationPortion { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public IdentificationPortionType UniqueIdentificationPortion { get; set; }
    }
}