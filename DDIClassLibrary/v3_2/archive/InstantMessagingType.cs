using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class InstantMessagingType
    {
        public InstantMessagingType()
        {

        }

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

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string IMIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType TypeOfInstantMessaging { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public DateType EffectivePeriod { get; set; }

    }
}