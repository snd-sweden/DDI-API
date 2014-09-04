using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class ConceptSchemeType : MaintainableType
    {
        public ConceptSchemeType()
        {
            this.ConceptSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ConceptSchemeReference = new List<SchemeReferenceType>();
            this.Concept = new List<ConceptType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ConceptGroup = new List<ConceptGroupType>();
            this.ConceptGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> ConceptSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public VocabularyType Vocabulary { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ConceptType> Concept { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<ConceptGroupType> ConceptGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> ConceptGroupReference { get; set; }

    }
}