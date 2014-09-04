using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LimitedCodeSegmentCapturedType
    {
        public LimitedCodeSegmentCapturedType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string arrayBase { get; set; }

        private Nullable<int> _startPosition;

        [System.Xml.Serialization.XmlAttribute()]
        public int startPosition
        {
            get
            {
                if (_startPosition.HasValue)
                    return _startPosition.Value;
                return 0; //default value;
            }
            set
            {
                this._startPosition = value;
            }
        }

        public bool ShouldSerializestartPosition()
        {
            return _startPosition.HasValue;
        }

        private Nullable<int> _length;

        [System.Xml.Serialization.XmlAttribute()]
        public int length
        {
            get
            {
                if (_length.HasValue)
                    return _length.Value;
                return 0; //default value;
            }
            set
            {
                this._length = value;
            }
        }

        public bool ShouldSerializelength()
        {
            return _length.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public StructuredStringType Description { get; set; }

    }
}