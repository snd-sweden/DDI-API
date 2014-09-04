using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedTextRepresentationType : VersionableType
    {
        public ManagedTextRepresentationType()
        {
            this.ManagedTextRepresentationName = new List<NameType>();
            this.Label = new List<LabelType>();
        }

        private Nullable<int> _maxLength;

        [System.Xml.Serialization.XmlAttribute()]
        public int maxLength
        {
            get
            {
                if (_maxLength.HasValue)
                    return _maxLength.Value;
                return 0; //default value;
            }
            set
            {
                this._maxLength = value;
            }
        }

        public bool ShouldSerializemaxLength()
        {
            return _maxLength.HasValue;
        }

        private Nullable<int> _minLength;

        [System.Xml.Serialization.XmlAttribute()]
        public int minLength
        {
            get
            {
                if (_minLength.HasValue)
                    return _minLength.Value;
                return 0; //default value;
            }
            set
            {
                this._minLength = value;
            }
        }

        public bool ShouldSerializeminLength()
        {
            return _minLength.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string regExp { get; set; }

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
        public List<NameType> ManagedTextRepresentationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CodeValueType GenericOutputFormat { get; set; }

    }
}