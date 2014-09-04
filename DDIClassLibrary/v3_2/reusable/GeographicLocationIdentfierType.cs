using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicLocationIdentifierType
    {
        public GeographicLocationIdentifierType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string GeographicCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType AuthorizedSourceReference { get; set; }
    }
}