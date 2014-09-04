using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class LifecycleEventType : IdentifiableType
    {
        public LifecycleEventType()
        {
            this.ObjectType = "LifecycleEvent";

            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.Relationship = new List<RelationshipType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType ElementType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType Date { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<RelationshipType> Relationship { get; set; }
    }
}