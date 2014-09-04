using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class FundingInformationType
    {
        public FundingInformationType()
        {
            this.AgencyOrganizationReference = new List<ReferenceType>();
            this.GrantNumber = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType FunderRole { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public List<string> GrantNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType Description { get; set; }
    }
}