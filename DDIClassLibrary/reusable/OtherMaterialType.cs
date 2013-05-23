using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class OtherMaterialType : IdentifiableType
    {
        public OtherMaterialType()
        {
            this.ObjectType = "OtherMaterial";

            this.Relationship = new List<RelationshipType>();
            this.Segment = new List<SegmentType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string ExternalURLReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string ExternalURNReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<RelationshipType> Relationship { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string MIMEType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<SegmentType> Segment { get; set; }
    }
}