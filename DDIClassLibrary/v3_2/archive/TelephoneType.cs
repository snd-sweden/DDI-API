using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class TelephoneType
    {
        public TelephoneType()
        {

        }


        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        private Nullable<bool> _isPreferred;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPreferred
        {
            get
            {
                if (_isPreferred.HasValue)
                    return _isPreferred.Value;
                return false; //default value;
            }
            set
            {
                this._isPreferred = value;
            }
        }

        public bool ShouldSerializeisPreferred()
        {
            return _isPreferred.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public string TelephoneNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType TypeOfTelephone { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public DateType EffectivePeriod { get; set; }

    }
}