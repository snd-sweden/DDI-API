using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RepresentationType
    {
        public RepresentationType()
        {

        }

        [System.Xml.Serialization.XmlAttribute()]
        public string missingValue { get; set; }

        private Nullable<bool> _blankIsMissingValue;

        [System.Xml.Serialization.XmlAttribute()]
        public bool blankIsMissingValue
        {
            get
            {
                if (_blankIsMissingValue.HasValue)
                    return _blankIsMissingValue.Value;
                return true; //default value;
            }
            set
            {
                this._blankIsMissingValue = value;
            }
        }

        public bool ShouldSerializeblankIsMissingValue()
        {
            return _blankIsMissingValue.HasValue;
        }

        private Nullable<CategoryRelationCodeType> _classificationLevel;

        [System.Xml.Serialization.XmlAttribute()]
        public CategoryRelationCodeType classificationLevel
        {
            get
            {
                if (_classificationLevel.HasValue)
                    return _classificationLevel.Value;
                return CategoryRelationCodeType.Nominal; //default value;
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
        
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType GenericOutputFormat { get; set; }
    }
}