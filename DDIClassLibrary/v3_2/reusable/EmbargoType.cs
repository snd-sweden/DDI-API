using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class EmbargoType : IdentifiableType
    {
        public EmbargoType()
        {
            this.EmbargoName = new List<NameType>();
            this.Label = new List<LabelType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> EmbargoName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public DateType Date { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredStringType Rationale { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType EnforcementAgencyOrganizationReference { get; set; }
    }
}