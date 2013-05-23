using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_1")]
    public class UsedType : IHaveDefaultValues
    {
        public UsedType()
        {
            this.AlternateName = new List<InternationalStringType>();
            this.Description = new List<StructuredStringType>();
            this.Instructions = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string defaultValue { get; set; }

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

        [System.Xml.Serialization.XmlAttribute()]
        public string path { get; set; }

        private Nullable<bool> _required;

        [System.Xml.Serialization.XmlAttribute()]
        public bool required
        {
            get
            {
                if (_required.HasValue)
                    return _required.Value;
                return false; //default value;
            }
            set
            {
                this._required = value;
            }
        }

        public bool ShouldSerializerequired()
        {
            return _required.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> AlternateName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Instructions { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._fixedValue.HasValue) this._fixedValue = false;
                if (!this._required.HasValue) this._required = false;
            }
        }
    }
}