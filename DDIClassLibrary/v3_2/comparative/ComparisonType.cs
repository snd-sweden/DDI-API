using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class ComparisonType : MaintainableType
    {
        public ComparisonType()
        {
            this.ComparisonName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ConceptMap = new List<GenericMapType>();
            this.ConceptMapReference = new List<ReferenceType>();
            this.VariableMap = new List<GenericMapType>();
            this.VariableMapReference = new List<ReferenceType>();
            this.QuestionMap = new List<GenericMapType>();
            this.QuestionMapReference = new List<ReferenceType>();
            this.CategoryMap = new List<GenericMapType>();
            this.CategoryMapReference = new List<ReferenceType>();
            this.RepresentationMap = new List<GenericMapType>();
            this.RepresentationMapReference = new List<ReferenceType>();
            this.UniverseMap = new List<GenericMapType>();
            this.UniverseMapReference = new List<ReferenceType>();
            this.Note = new List<NoteType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ComparisonName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<GenericMapType> ConceptMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> ConceptMapReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<GenericMapType> VariableMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> VariableMapReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<GenericMapType> QuestionMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> QuestionMapReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<GenericMapType> CategoryMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ReferenceType> CategoryMapReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<GenericMapType> RepresentationMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<ReferenceType> RepresentationMapReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 15)]
        public List<GenericMapType> UniverseMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ReferenceType> UniverseMapReference { get; set; }

    }
}