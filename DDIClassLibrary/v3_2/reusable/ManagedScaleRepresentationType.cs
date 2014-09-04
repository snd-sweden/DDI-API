using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedScaleRepresentationType : VersionableType
    {
        public ManagedScaleRepresentationType()
        {
            this.ManagedScaleRepresentationName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ScaleDimension = new List<ScaleDimensionType>();
            this.DimensionIntersect = new List<DimensionIntersectType>();
        }

        private Nullable<CategoryRelationCodeType> _classificationLevel;

        [System.Xml.Serialization.XmlAttribute()]
        public CategoryRelationCodeType classificationLevel
        {
            get
            {
                if (_classificationLevel.HasValue)
                    return _classificationLevel.Value;
                return 0; //default value;
            }
            set
            {
                this._classificationLevel = value;
            }
        }

        public bool ShouldSerializeclassificationLevel()
        {
            return _classificationLevel.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ManagedScaleRepresentationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CodeValueType GenericOutputFormat { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ScaleDimensionType> ScaleDimension { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<DimensionIntersectType> DimensionIntersect { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public CodeValueType DisplayLayout { get; set; }
    }
}