using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class CollectionType
    {
        public CollectionType()
        {
            this.LocationInArchive = new List<InternationalStringType>();
            this.OriginalArchiveOrganizationReference = new List<ReferenceType>();
            this.AvailabilityStatus = new List<StructuredStringType>();
            this.CollectionCompleteness = new List<StructuredStringType>();
            this.Item = new List<ItemType>();
            this.Collection = new List<CollectionType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> LocationInArchive { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string CallNumber { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 2)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public Nullable<int> ItemQuantity { get; set; }

        public bool ShouldSerializeItemQuantity()
        {
            return ItemQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StudyClassType StudyClass { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public AccessType DefaultAccess { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> OriginalArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<StructuredStringType> AvailabilityStatus { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public Nullable<int> DataFileQuantity { get; set; }

        public bool ShouldSerializeDataFileQuantity()
        {
            return DataFileQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<StructuredStringType> CollectionCompleteness { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ItemType> Item { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<CollectionType> Collection { get; set; }
    }
}