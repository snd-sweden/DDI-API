using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ResponseCardinalityType
    {
        public ResponseCardinalityType()
        {

        }

        private Nullable<bool> _minimumResponses;

        [System.Xml.Serialization.XmlAttribute()]
        public bool minimumResponses
        {
            get
            {
                if (_minimumResponses.HasValue)
                    return _minimumResponses.Value;
                return false; //default value;
            }
            set
            {
                this._minimumResponses = value;
            }
        }

        public bool ShouldSerializeminimumResponses()
        {
            return _minimumResponses.HasValue;
        }

        private Nullable<bool> _maximumResponses;

        [System.Xml.Serialization.XmlAttribute()]
        public bool maximumResponses
        {
            get
            {
                if (_maximumResponses.HasValue)
                    return _maximumResponses.Value;
                return false; //default value;
            }
            set
            {
                this._maximumResponses = value;
            }
        }

        public bool ShouldSerializemaximumResponses()
        {
            return _maximumResponses.HasValue;
        }     
    }
}