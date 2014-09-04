using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class ArchiveSpecificType
    {
        public ArchiveSpecificType()
        {
            this.Item = new List<ItemType>();
            this.Collection = new List<CollectionType>();
            this.DefaultAccess = new List<AccessType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.Budget = new List<BudgetType>();
            this.QualityStatementReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType ArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ItemType> Item { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CollectionType> Collection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<AccessType> DefaultAccess { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<BudgetType> Budget { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<ReferenceType> QualityStatementReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public CoverageType Coverage { get; set; }
    }
}