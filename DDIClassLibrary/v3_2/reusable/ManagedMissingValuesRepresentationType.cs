using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedMissingValuesRepresentationType : VersionableType
    {
        public ManagedMissingValuesRepresentationType()
        {
            this.ManagedMissingValuesRepresentationName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.MissingCodeRepresentation = new List<CodeRepresentationBaseType>();
            this.MissingNumericRepresentation = new List<NumericRepresentationBaseType>();
            this.MissingTextRepresentation = new List<TextRepresentationBaseType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ManagedMissingValuesRepresentationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CodeRepresentationBaseType> MissingCodeRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<NumericRepresentationBaseType> MissingNumericRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<TextRepresentationBaseType> MissingTextRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ProcessingInstructionReferenceType ProcessingInstructionReference { get; set; }
    }
}