using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CreatorType
    {
        public CreatorType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public BibliographicNameType CreatorName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType CreatorReference { get; set; }

    }
}