using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class PhysicalStructureSchemeType : MaintainableType
    {
        public PhysicalStructureSchemeType()
        {
            this.PhysicalStructureSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.PhysicalStructureSchemeReference = new List<SchemeReferenceType>();
            this.PhysicalStructure = new List<PhysicalStructureType>();
            this.PhysicalStructureReference = new List<ReferenceType>();
            this.PhysicalStructureGroup = new List<PhysicalStructureGroupType>();
            this.PhysicalStructureGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> PhysicalStructureSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> PhysicalStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 4)]
        public List<PhysicalStructureType> PhysicalStructure { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 5)]
        public List<ReferenceType> PhysicalStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 6)]
        public List<PhysicalStructureGroupType> PhysicalStructureGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 7)]
        public List<ReferenceType> PhysicalStructureGroupReference { get; set; }
    }
}