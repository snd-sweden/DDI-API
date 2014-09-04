using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class ItemType
    {
        public ItemType()
        {
            this.LocationInArchive = new List<InternationalStringType>();
            this.OriginalArchiveOrganizationReference = new List<ReferenceType>();
            this.AvailabilityStatus = new List<StructuredStringType>();
            this.CollectionCompleteness = new List<StructuredStringType>();
            this.Item = new List<ItemType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> LocationInArchive { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string CallNumber { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 2)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public InternationalStringType Format { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public InternationalStringType Media { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public StudyClassType StudyClass { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public AccessType Access { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> OriginalArchiveOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<StructuredStringType> AvailabilityStatus { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public Nullable<int> DataFileQuantity { get; set; }

        public bool ShouldSerializeDataFileQuantity()
        {
            return DataFileQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<StructuredStringType> CollectionCompleteness { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ItemType> Item { get; set; }
    }
}