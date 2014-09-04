using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class DomainSpecificValueType
    {
        public DomainSpecificValueType()
        {
            this.Value = new List<DDIClassLibrary.v3_2.reusable.ValueType>();
        }

        private Nullable<int> _attachmentDomain;

        [System.Xml.Serialization.XmlAttribute()]
        public int attachmentDomain
        {
            get
            {
                if (_attachmentDomain.HasValue)
                    return _attachmentDomain.Value;
                return 0; //default value;
            }
            set
            {
                this._attachmentDomain = value;
            }
        }

        public bool ShouldSerializeattachmentDomain()
        {
            return _attachmentDomain.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = false, Order = 0)]
        public List<DDIClassLibrary.v3_2.reusable.ValueType> Value { get; set; }

    }
}