using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class FundingInformationType
    {
        public FundingInformationType()
        {
            this.AgencyOrganizationReference = new List<ReferenceType>();
            this.GrantNumber = new List<string>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string role { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> AgencyOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<string> GrantNumber { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }
    }
}