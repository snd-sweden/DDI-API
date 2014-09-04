using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class OrganizationNameType : NameType
    {
        public OrganizationNameType()
        {

        }

        private Nullable<bool> _isFormal;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isFormal
        {
            get
            {
                if (_isFormal.HasValue)
                    return _isFormal.Value;
                return false; //default value;
            }
            set
            {
                this._isFormal = value;
            }
        }

        public bool ShouldSerializeisFormal()
        {
            return _isFormal.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public InternationalStringType Abbreviation { get; set; }

        public bool ShouldSerializeAbbreviation()
        {
            return Abbreviation != null;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType TypeOfOrganizationName { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public DateType EffectivePeriod { get; set; }

    }
}