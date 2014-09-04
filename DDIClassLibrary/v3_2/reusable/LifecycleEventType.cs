using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LifecycleEventType : IdentifiableType
    {
        public LifecycleEventType()
        {
            this.Label = new List<LabelType>();
            this.AgencyOrganizationReference = new List<ReferenceType>();
            this.Relationship = new List<RelationshipType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType EventType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DateType Date { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public List<ReferenceType> AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<RelationshipType> Relationship { get; set; }
    }
}