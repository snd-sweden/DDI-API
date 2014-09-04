using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class PublisherType
    {
        public PublisherType()
        {
            this.PublisherRole = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public BibliographicNameType PublisherName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> PublisherRole { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType PublisherReference { get; set; }

    }
}