using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class OrganizationSchemeType : MaintainableType
    {
        public OrganizationSchemeType()
        {
            this.OrganizationSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.OrganizationSchemeReference = new List<SchemeReferenceType>();
            this.Organization = new List<OrganizationType>();
            this.OrganizationReference = new List<ReferenceType>();
            this.Individual = new List<IndividualType>();
            this.IndividualReference = new List<ReferenceType>();
            this.Relation = new List<RelationType>();
            this.RelationRefererence = new List<ReferenceType>();
            this.OrganizationGroup = new List<OrganizationGroupType>();
            this.OrganizationGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> OrganizationSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> OrganizationSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<OrganizationType> Organization { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> OrganizationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<IndividualType> Individual { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> IndividualReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<RelationType> Relation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> RelationRefererence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<OrganizationGroupType> OrganizationGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> OrganizationGroupReference { get; set; }

    }
}