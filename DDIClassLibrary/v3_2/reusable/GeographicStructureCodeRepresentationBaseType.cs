using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicStructureCodeRepresentationBaseType : RepresentationType
    {
        public GeographicStructureCodeRepresentationBaseType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IncludedGeographicStructureCodesType IncludedGeographicStructureCodes { get; set; }
    }
}