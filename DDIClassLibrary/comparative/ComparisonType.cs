using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class ComparisonType : MaintainableType
    {
        public ComparisonType()
        {
            this.ObjectType = "Comparison";

            this.ComparisonName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ConceptMap = new List<GenericMapType>();
            this.VariableMap = new List<GenericMapType>();
            this.QuestionMap = new List<GenericMapType>();
            this.CategoryMap = new List<GenericMapType>();
            this.CodeMap = new List<GenericMapType>();
            this.UniverseMap = new List<GenericMapType>();
            this.Note = new List<NoteType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ComparisonName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<GenericMapType> ConceptMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<GenericMapType> VariableMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<GenericMapType> QuestionMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<GenericMapType> CategoryMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<GenericMapType> CodeMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<GenericMapType> UniverseMap { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 9)]
        public List<NoteType> Note { get; set; }
    }
}