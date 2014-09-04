using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class TextRepresentationBaseType : RepresentationType
    {
        public TextRepresentationBaseType()
        {

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

    }
}