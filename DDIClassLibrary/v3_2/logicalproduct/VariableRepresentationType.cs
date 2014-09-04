using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class VariableRepresentationType
    {
        public VariableRepresentationType()
        {
        }

        private Nullable<AdditivityCodeType> _additivity;

        [System.Xml.Serialization.XmlAttribute()]
        public AdditivityCodeType additivity
        {
            get
            {
                if (_additivity.HasValue)
                    return _additivity.Value;
                return 0; //default value;
            }
            set
            {
                this._additivity = value;
            }
        }

        public bool ShouldSerializeadditivity()
        {
            return _additivity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType VariableRole { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<ReferenceType> WeightVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType StandardWeightReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType ImputationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ConcatenatedValueType ConcatenatedValue { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public ProcessingInstructionReferenceType ProcessingInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement("CodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.CodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("DateTimeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.DateTimeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("ExternalCategoryRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ExternalCategoryRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("GeographicLocationCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicLocationCodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("GeographicStructureCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicStructureCodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("NumericRepresentation", typeof(DDIClassLibrary.v3_2.reusable.NumericRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("ScaleRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ScaleRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        [System.Xml.Serialization.XmlElement("TextRepresentation", typeof(DDIClassLibrary.v3_2.reusable.TextRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 6)]
        public RepresentationType ValueRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public RepresentationReferenceType DateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 8)]
        public RepresentationReferenceType NumericRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public RepresentationReferenceType ScaleRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 10)]
        public RepresentationReferenceType TextRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public ReferenceType MissingValuesReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 12)]
        public ReferenceType MeasurementUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 13)]
        public ContentDateOffsetType ContentDateOffset { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 14)]
        public CodeValueType AggregationMethod { get; set; }
    }
}