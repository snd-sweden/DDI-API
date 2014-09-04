using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class SourceRepresentationType
    {
        public SourceRepresentationType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType ManagedDateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public ReferenceType ManagedMissingValuesRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public ReferenceType ManagedNumericRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ReferenceType ManagedScaleRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public ReferenceType ManagedTextRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public SchemeReferenceType CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public ReferenceType CodeListReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public GeographicStructureReferenceType GeographicStructureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 8)]
        public GeographicLocationReferenceType GeographicLocationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public ReferenceType ConceptReference { get; set; }
    }
}