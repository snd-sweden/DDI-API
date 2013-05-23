using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class EmbargoType : IdentifiableType
    {
        public EmbargoType()
        {
            this.ObjectType = "Embargo";

            this.EmbargoName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.Rationale = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> EmbargoName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public DateType Date { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public List<StructuredStringType> Rationale { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType EnforcementAgencyOrganizationReference { get; set; }
    }
}