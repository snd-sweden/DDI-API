using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class CollectionType
    {
        public CollectionType()
        {
            this.LocationInArchive = new List<InternationalStringType>();
            this.OriginalArchiveOrganizationReference = new List<ReferenceType>();
            this.Item = new List<ItemType>();
            this.Collection = new List<CollectionType>();
        }


        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> LocationInArchive { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string CallNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public Nullable<int> ItemQuantity { get; set; }

        public bool ShouldSerializeItemQuantity()
        {
            return ItemQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public StudyClassType StudyClass { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public AccessType DefaultAccess { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> OriginalArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public StructuredStringType AvailabilityStatus { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public Nullable<int> DataFileQuantity { get; set; }

        public bool ShouldSerializeDataFileQuantity()
        {
            return DataFileQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public StructuredStringType CollectionCompleteness { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ItemType> Item { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<CollectionType> Collection { get; set; }

    }
}