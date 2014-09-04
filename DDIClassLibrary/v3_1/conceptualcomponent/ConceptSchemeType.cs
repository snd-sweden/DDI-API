using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class ConceptSchemeType : MaintainableType
    {
        public ConceptSchemeType()
        {
            this.ObjectType = "ConceptScheme";

            this.ConceptSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ConceptSchemeReference = new List<ReferenceType>();
            this.Concept = new List<ConceptType>();
            this.DataElementConcept = new List<DataElementConceptType>();
            this.ConceptGroup = new List<ConceptGroupType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> ConceptSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public VocabularyType Vocabulary { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ConceptType> Concept { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<DataElementConceptType> DataElementConcept { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ConceptGroupType> ConceptGroup { get; set; }
    }
}