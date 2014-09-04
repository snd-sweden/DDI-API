using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class AuthorizationSourceType
    {
        public AuthorizationSourceType()
        {
            this.AuthorizingAgencyReference = new List<ReferenceType>();
            this.StatementOfAuthorization = new List<StructuredStringType>();
            this.LegalMandate = new List<string>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string authorizationDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> AuthorizingAgencyReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> StatementOfAuthorization { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<string> LegalMandate { get; set; }
    }
}