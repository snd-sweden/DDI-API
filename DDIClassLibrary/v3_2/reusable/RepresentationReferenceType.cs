using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RepresentationReferenceType : ReferenceType
    {
        public RepresentationReferenceType()
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
    }
}