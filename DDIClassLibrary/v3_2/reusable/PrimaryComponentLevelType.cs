using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class PrimaryComponentLevelType
    {
        public PrimaryComponentLevelType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType GeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public InternationalStringType CoverageLimitation { get; set; }

    }
}