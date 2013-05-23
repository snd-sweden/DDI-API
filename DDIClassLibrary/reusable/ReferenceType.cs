using System;
namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ReferenceType : IHaveDefaultValues
    {
        public ReferenceType()
        {

        }

        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
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

        [System.Xml.Serialization.XmlAttribute(DataType = "language")]
        public string objectLanguage { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
        public string sourceContext { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType Module { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Scheme { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public URNType URN { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public IDType ID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string IdentifyingAgency { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public VersionType Version { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
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