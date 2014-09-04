using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class AccessType : IdentifiableType
    {
        public AccessType()
        {
            this.AccessTypeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.AccessPermission = new List<FormType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> AccessTypeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType ConfidentialityStatement { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<FormType> AccessPermission { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public StructuredStringType Restrictions { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public StructuredStringType CitationRequirement { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public StructuredStringType DepositRequirement { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public StructuredStringType AccessConditions { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public StructuredStringType Disclaimer { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public AccessRestrictionDateType AccessRestrictionDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> ContactOrganizationReference { get; set; }
    }
}