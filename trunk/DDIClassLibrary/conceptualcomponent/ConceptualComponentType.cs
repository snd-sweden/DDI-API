using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class ConceptualComponentType : MaintainableType
    {
        public ConceptualComponentType()
        {
            this.ObjectType = "ConceptualComponent";

            this.ConceptualComponentModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.ConceptScheme = new List<ConceptSchemeType>();
            this.ConceptSchemeReference = new List<ReferenceType>();
            this.UniverseScheme = new List<UniverseSchemeType>();
            this.UniverseSchemeReference = new List<ReferenceType>();
            this.GeographicStructureScheme = new List<GeographicStructureSchemeType>();
            this.GeographicStructureSchemeReference = new List<ReferenceType>();
            this.GeographicLocationScheme = new List<GeographicLocationSchemeType>();
            this.GeographicLocationSchemelReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptualComponentModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 5)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ConceptSchemeType> ConceptScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> ConceptSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<UniverseSchemeType> UniverseScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> UniverseSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<GeographicStructureSchemeType> GeographicStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<GeographicLocationSchemeType> GeographicLocationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<ReferenceType> GeographicLocationSchemelReference { get; set; }
    }
}