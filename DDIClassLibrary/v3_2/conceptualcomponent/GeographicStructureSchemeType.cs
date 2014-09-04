using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class GeographicStructureSchemeType : MaintainableType
    {
        public GeographicStructureSchemeType()
        {
            this.GeographicStructureSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.GeographicStructureSchemeReference = new List<SchemeReferenceType>();
            this.GeographicStructure = new List<GeographicStructureType>();
            this.GeographicStructureReference = new List<ReferenceType>();
            this.GeographicStructureGroup = new List<GeographicStructureGroupType>();
            this.GeographicStructureGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> GeographicStructureSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<GeographicStructureType> GeographicStructure { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> GeographicStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<GeographicStructureGroupType> GeographicStructureGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> GeographicStructureGroupReference { get; set; }

    }
}