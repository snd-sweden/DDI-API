using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class BibliographicNameType : InternationalStringType
    {
        public BibliographicNameType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string affiliation { get; set; }
    }
}