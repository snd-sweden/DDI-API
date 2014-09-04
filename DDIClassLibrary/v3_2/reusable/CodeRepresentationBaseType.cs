using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CodeRepresentationBaseType : RepresentationType
    {
        public CodeRepresentationBaseType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType CodeListReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeSubsetInformationType CodeSubsetInformation { get; set; }
    }
}