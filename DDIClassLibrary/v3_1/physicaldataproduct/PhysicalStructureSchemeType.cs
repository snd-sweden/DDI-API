using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class PhysicalStructureSchemeType : MaintainableType
    {
        public PhysicalStructureSchemeType()
        {
            this.ObjectType = "PhysicalStructureScheme";

            this.PhysicalStructureSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.PhysicalStructureSchemeReference = new List<PhysicalStructureSchemeType>();
            this.PhysicalStructure = new List<PhysicalStructureType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> PhysicalStructureSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PhysicalStructureSchemeType> PhysicalStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 4)]
        public List<PhysicalStructureType> PhysicalStructure { get; set; }
    }
}