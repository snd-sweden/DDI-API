using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class RepresentedVariableType : VersionableType
    {
        public RepresentedVariableType()
        {
            this.RepresentedVariableName = new List<NameType>();
            this.Label = new List<LabelType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RepresentedVariableName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ReferenceType ConceptualVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public ReferenceType UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public SchemeReferenceType CategorySchemeReference { get; set; }
                
        [System.Xml.Serialization.XmlElement("CodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.CodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("DateTimeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.DateTimeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("ExternalCategoryRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ExternalCategoryRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("GeographicLocationCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicLocationCodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("GeographicStructureCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicStructureCodeRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("NumericRepresentation", typeof(DDIClassLibrary.v3_2.reusable.NumericRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("ScaleRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ScaleRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        [System.Xml.Serialization.XmlElement("TextRepresentation", typeof(DDIClassLibrary.v3_2.reusable.TextRepresentationBaseType), Namespace = "ddi:reusable:3_2", Order = 7)]
        public RepresentationType ValueRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 8)]
        public RepresentationReferenceType DateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public RepresentationReferenceType NumericRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 10)]
        public RepresentationReferenceType ScaleRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 11)]
        public RepresentationReferenceType TextRepresentationReference { get; set; }

    }
}