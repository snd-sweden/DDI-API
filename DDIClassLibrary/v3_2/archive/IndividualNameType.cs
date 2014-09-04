using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class IndividualNameType
    {
        public IndividualNameType()
        {
            this.Middle = new List<string>();
        }

        private Nullable<SexSpecificationType> _sex;

        [System.Xml.Serialization.XmlAttribute()]
        public SexSpecificationType sex
        {
            get
            {
                if (_sex.HasValue)
                    return _sex.Value;
                return 0; //default value;
            }
            set
            {
                this._sex = value;
            }
        }

        public bool ShouldSerializesex()
        {
            return _sex.HasValue;
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
        public string context { get; set; }

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
        
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Prefix { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string FirstGiven { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<string> Middle { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string LastFamily { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string Suffix { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public InternationalStringType FullName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public DateType EffectivePeriod { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public InternationalStringType Abbreviation { get; set; }

        public bool ShouldSerializeAbbreviation()
        {
            return Abbreviation != null;
        }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public CodeValueType TypeOfIndividualName { get; set; }

    }
}