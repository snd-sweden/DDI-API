using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class ConceptualComponentType : MaintainableType
    {
        public ConceptualComponentType()
        {
            this.ConceptualComponentModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.ConceptScheme = new List<ConceptSchemeType>();
            this.ConceptSchemeReference = new List<SchemeReferenceType>();
            this.UniverseScheme = new List<UniverseSchemeType>();
            this.UniverseSchemeReference = new List<SchemeReferenceType>();
            this.ConceptualVariableScheme = new List<ConceptualVariableSchemeType>();
            this.ConceptualVariableSchemeReference = new List<SchemeReferenceType>();
            this.GeographicStructureScheme = new List<GeographicStructureSchemeType>();
            this.GeographicStructureSchemeReference = new List<SchemeReferenceType>();
            this.GeographicLocationScheme = new List<GeographicLocationSchemeType>();
            this.GeographicLocationSchemeReference = new List<SchemeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptualComponentModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<OtherMaterialType> OtherMaterial { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ConceptSchemeType> ConceptScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<SchemeReferenceType> ConceptSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<UniverseSchemeType> UniverseScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<SchemeReferenceType> UniverseSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ConceptualVariableSchemeType> ConceptualVariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 10)]
        public List<SchemeReferenceType> ConceptualVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<GeographicStructureSchemeType> GeographicStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 12)]
        public List<SchemeReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<GeographicLocationSchemeType> GeographicLocationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 14)]
        public List<SchemeReferenceType> GeographicLocationSchemeReference { get; set; }

    }
}