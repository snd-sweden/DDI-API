using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RelationshipType
    {
        public RelationshipType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType RelatedToReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public StructuredStringType RelationshipDescription { get; set; }
    }
}