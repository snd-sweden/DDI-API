using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ContributorType
    {
        public ContributorType()
        {
            ContributorRole = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public BibliographicNameType ContributorName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> ContributorRole { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType ContributorReference { get; set; }
    }
}