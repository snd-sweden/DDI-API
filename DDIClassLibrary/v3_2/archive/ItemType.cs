using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class ItemType
    {
        public ItemType()
        {
            this.LocationInArchive = new List<InternationalStringType>();
            this.OriginalArchiveOrganizationReference = new List<ReferenceType>();
            this.Item = new List<ItemType>();
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
        public CodeValueType ItemFormat { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CodeValueType Media { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public StudyClassType StudyClass { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public AccessType Access { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> OriginalArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public StructuredStringType AvailabilityStatus { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public Nullable<int> DataFileQuantity { get; set; }

        public bool ShouldSerializeDataFileQuantity()
        {
            return DataFileQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public StructuredStringType CollectionCompleteness { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<ItemType> Item { get; set; }

    }
}