using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class ConceptualVariableSchemeType : MaintainableType
    {
        public ConceptualVariableSchemeType()
        {
            this.ConceptualVariableSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ConceptualVariableSchemeReference = new List<SchemeReferenceType>();
            this.ConceptualVariable = new List<ConceptualVariableType>();
            this.ConceptualVariableReference = new List<ReferenceType>();
            this.ConceptualVariableGroup = new List<ConceptualVariableGroupType>();
            this.ConceptualVariableGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptualVariableSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> ConceptualVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ConceptualVariableType> ConceptualVariable { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> ConceptualVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<ConceptualVariableGroupType> ConceptualVariableGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> ConceptualVariableGroupReference { get; set; }

    }
}