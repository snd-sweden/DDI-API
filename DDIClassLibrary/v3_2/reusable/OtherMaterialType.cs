using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class OtherMaterialType : IdentifiableType
    {
        public OtherMaterialType()
        {
            this.ExternalURLReference = new List<string>();
            this.Relationship = new List<RelationshipType>();
            this.Segment = new List<SegmentType>();
        }
        
        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public List<string> ExternalURLReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string ExternalURNReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<RelationshipType> Relationship { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CodeValueType MIMEType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<SegmentType> Segment { get; set; }
    }
}