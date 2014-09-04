using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(TypeName = "SchemeReferenceType", Namespace = "ddi:reusable:3_2")]
    public class SchemeReferenceType : IHaveDefaultValues
    {
        public SchemeReferenceType()
        {
            this.Exclude = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string URI { get; set; }

        private Nullable<bool> _isExternal;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isExternal
        {
            get
            {
                if (_isExternal.HasValue)
                    return _isExternal.Value;
                return false; //default value;
            }
            set
            {
                this._isExternal = value;
            }
        }

        public bool ShouldSerializeisExternal()
        {
            return _isExternal.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string externalReferenceDefaultURI { get; set; }

        private Nullable<bool> _isReference;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isReference
        {
            get
            {
                return true;
            }
            set
            {
                if (value == false)
                    this._isReference = null;
                else this._isReference = true;
            }
        }

        public bool ShouldSerializeisReference()
        {
            if (_isReference.HasValue)
                return true;
            return false;
        }

        private Nullable<bool> _lateBound;

        [System.Xml.Serialization.XmlAttribute()]
        public bool lateBound
        {
            get
            {
                if (_lateBound.HasValue)
                    return _lateBound.Value;
                return false; //default value;
            }
            set
            {
                this._lateBound = value;
            }
        }

        public bool ShouldSerializelateBound()
        {
            return _lateBound.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string lateBoundRestriction { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string objectLanguage { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string sourceContext { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public URNType URN { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public DDIAgencyIDType Agency { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public IDType ID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public VersionType Version { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public TypeOfObjectType TypeOfObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public MaintainableObjectType MaintainableObject { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> Exclude { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public virtual void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isExternal.HasValue) this._isExternal = false;
                this.isReference = true;
                if (!this._lateBound.HasValue) this._lateBound = false;
            }
        }

    }
}