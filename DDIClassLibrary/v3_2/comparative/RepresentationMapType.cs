using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class RepresentationMapType : VersionableType
    {
        public RepresentationMapType()
        {
        }

        private Nullable<bool> _contextSpecificComparison;

        [System.Xml.Serialization.XmlAttribute()]
        public bool contextSpecificComparison
        {
            get
            {
                if (_contextSpecificComparison.HasValue)
                    return _contextSpecificComparison.Value;
                return false; //default value;
            }
            set
            {
                this._contextSpecificComparison = value;
            }
        }

        public bool ShouldSerializecontextSpecificComparison()
        {
            return _contextSpecificComparison.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RepresentationMapName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public SourceRepresentationType SourceRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public TargetRepresentationType TargetRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CorrespondenceType Correspondence { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public ReferenceType ProcessingInstructionReference { get; set; }

    }
}