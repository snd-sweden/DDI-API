using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NoteType : IdentifiableType
    {
        public NoteType()
        {
            this.Relationship = new List<RelationshipType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfNote { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType NoteSubject { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<RelationshipType> Relationship { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Responsibility { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public InternationalStringType Header { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 5)]
        public StructuredStringType NoteContent { get; set; }

        //[System.Xml.Serialization.XmlElement(IsNullable = false, Order = 6)]
        //public ProprietaryInfoType ProprietaryInfo { get; set; }
    }
}