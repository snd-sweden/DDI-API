using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class GeographicStructureSchemeType : MaintainableType
    {
        public GeographicStructureSchemeType()
        {
            this.ObjectType = "GeographicStructureScheme";

            this.GeographicStructureSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.GeographicStructureSchemeReference = new List<ReferenceType>();
            this.GeographicStructure = new List<GeographicStructureType>();
            this.GeographicStructureReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> GeographicStructureSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<GeographicStructureType> GeographicStructure { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 5)]
        public List<ReferenceType> GeographicStructureReference { get; set; }
    }
}