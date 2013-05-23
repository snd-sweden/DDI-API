using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class RelationshipType
    {
        public RelationshipType()
        {
            this.RelationshipDescription = new List<InternationalStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType RelatedToReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> RelationshipDescription { get; set; }
    }
}