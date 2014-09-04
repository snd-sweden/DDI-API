using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_2")]
    public class UsedType : IHaveDefaultValues
    {
        public UsedType()
        {

        }

        private Nullable<bool> _isRequired;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isRequired
        {
            get
            {
                if (_isRequired.HasValue)
                    return _isRequired.Value;
                return false; //default value;
            }
            set
            {
                this._isRequired = value;
            }
        }

        public bool ShouldSerializeisRequired()
        {
            return _isRequired.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string xpath { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string defaultValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string limitMaxOccurs { get; set; }

        private Nullable<bool> _fixedValue;

        [System.Xml.Serialization.XmlAttribute()]
        public bool fixedValue
        {
            get
            {
                if (_fixedValue.HasValue)
                    return _fixedValue.Value;
                return false; //default value;
            }
            set
            {
                this._fixedValue = value;
            }
        }

        public bool ShouldSerializefixedValue()
        {
            return _fixedValue.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public InternationalStringType AlternateName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public StructuredStringType Instructions { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._fixedValue.HasValue) this._fixedValue = false;
                if (!this._isRequired.HasValue) this._isRequired = false;
            }
        }
    }
}