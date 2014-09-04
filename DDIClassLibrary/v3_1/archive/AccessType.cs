using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class AccessType : IdentifiableType
    {
        public AccessType()
        {
            this.ObjectType = "Access";

            this.AccessTypeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ConfidentialityStatement = new List<StructuredStringType>();
            this.AccessPermission = new List<FormType>();
            this.Restrictions = new List<StructuredStringType>();
            this.CitationRequirement = new List<StructuredStringType>();
            this.DepositRequirement = new List<StructuredStringType>();
            this.AccessConditions = new List<StructuredStringType>();
            this.Disclaimer = new List<StructuredStringType>();
            this.ContactOrganizationReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> AccessTypeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<StructuredStringType> ConfidentialityStatement { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<FormType> AccessPermission { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<StructuredStringType> Restrictions { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<StructuredStringType> CitationRequirement { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<StructuredStringType> DepositRequirement { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<StructuredStringType> AccessConditions { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<StructuredStringType> Disclaimer { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public AccessRestrictionDateType AccessRestrictionDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> ContactOrganizationReference { get; set; }
    }
}