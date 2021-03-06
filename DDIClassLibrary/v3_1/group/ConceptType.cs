﻿using DDIClassLibrary.v3_1.conceptualcomponent;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class ConceptType
    {
        public ConceptType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", Order = 0)]
        public ConceptualComponentType ConceptualComponent { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}