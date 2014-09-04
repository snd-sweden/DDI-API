using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class ArchiveSpecificType
    {
        public ArchiveSpecificType()
        {
            this.Item = new List<ItemType>();
            this.Collection = new List<CollectionType>();
            this.DefaultAccess = new List<AccessType>();
            this.FundingInformation = new List<FundingInformationType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType ArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ItemType> Item { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CollectionType> Collection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<AccessType> DefaultAccess { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<FundingInformationType> FundingInformation { get; set; }
    }
}