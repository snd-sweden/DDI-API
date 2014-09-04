using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedRepresentationSchemeType : MaintainableType
    {
        public ManagedRepresentationSchemeType()
        {
            this.ManagedRepresentationSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ManagedRepresentationSchemeReference = new List<ReferenceType>();
            this.ManagedRepresentation = new List<VersionableType>();
            this.ManagedDateTimeRepresentationReference = new List<ReferenceType>();
            this.ManagedMissingValuesRepresentationReference = new List<ReferenceType>();
            this.ManagedNumericRepresentationReference = new List<ReferenceType>();
            this.ManagedScaleRepresentationReference = new List<ReferenceType>();
            this.ManagedTextRepresentationReference = new List<ReferenceType>();
            this.ManagedRepresentationGroup = new List<ManagedRepresentationGroupType>();
            this.ManagedRepresentationGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ManagedRepresentationSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> ManagedRepresentationSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement("ManagedDateTimeRepresentation", typeof(ManagedDateTimeRepresentationType), Order = 4)]
        [System.Xml.Serialization.XmlElement("ManagedMissingValuesRepresentation", typeof(ManagedMissingValuesRepresentationType), Order = 4)]
        [System.Xml.Serialization.XmlElement("ManagedNumericRepresentation", typeof(ManagedNumericRepresentationType), Order = 4)]
        [System.Xml.Serialization.XmlElement("ManagedScaleRepresentation", typeof(ManagedScaleRepresentationType), Order = 4)]
        [System.Xml.Serialization.XmlElement("ManagedTextRepresentation", typeof(ManagedTextRepresentationType), Order = 4)]
        public List<VersionableType> ManagedRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> ManagedDateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> ManagedMissingValuesRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> ManagedNumericRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> ManagedScaleRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> ManagedTextRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ManagedRepresentationGroupType> ManagedRepresentationGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> ManagedRepresentationGroupReference { get; set; }
    }
}