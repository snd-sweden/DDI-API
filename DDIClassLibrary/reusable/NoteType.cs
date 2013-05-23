using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class NoteType : IdentifiableType
    {
        public NoteType()
        {
            this.ObjectType = "Note";

            this.Relationship = new List<RelationshipType>();
            this.Header = new List<InternationalStringType>();
            this.Content = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public NoteTypeCodeType type { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Subject { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<RelationshipType> Relationship { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Responsibility { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<InternationalStringType> Header { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 4)]
        public List<StructuredStringType> Content { get; set; }
    }
}