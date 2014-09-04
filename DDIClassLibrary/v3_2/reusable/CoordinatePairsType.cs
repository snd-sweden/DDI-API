using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CoordinatePairsType : TextDomainType
    {
        public CoordinatePairsType()
        {

        }

        private Nullable<bool> _maxArray;

        [System.Xml.Serialization.XmlAttribute()]
        public bool maxArray
        {
            get
            {
                if (_maxArray.HasValue)
                    return _maxArray.Value;
                return false; //default value;
            }
            set
            {
                this._maxArray = value;
            }
        }

        public bool ShouldSerializemaxArray()
        {
            return _maxArray.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string arraySeparator { get; set; }

    }
}