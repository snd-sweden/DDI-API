using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CodeType : IHaveDefaultValues
    {
        public CodeType()
        {
            this.Code = new List<CodeType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public Nullable<IsComprehensiveType> isComprehensive { get; set; }

        public bool ShouldSerializeisComprehensive()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "isComprehensive")]
        public string isComprehensiveValue
        {
            get
            {
                if (isComprehensive.HasValue)
                    return isComprehensive.ToString();
                return null;
            }
            set
            {
                IsComprehensiveType result;
                Enum.TryParse<IsComprehensiveType>(value, out result);
                isComprehensive = result;
            }
        }

        public bool ShouldSerializeisComprehensiveValue()
        {
            return this.isComprehensive.HasValue;
        }


        private Nullable<bool> _isDiscrete;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isDiscrete
        {
            get
            {
                if (_isDiscrete.HasValue)
                    return _isDiscrete.Value;
                return true; //default value;
            }
            set
            {
                this._isDiscrete = value;
            }
        }

        public bool ShouldSerializeisDiscrete()
        {
            return _isDiscrete.HasValue;
        }

        private Nullable<bool> _isTotal;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isTotal
        {
            get
            {
                if (_isTotal.HasValue)
                    return _isTotal.Value;
                return false; //default value;
            }
            set
            {
                this._isTotal = value;
            }
        }

        public bool ShouldSerializeisTotal()
        {
            return _isTotal.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int levelNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType CategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Value { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CodeType> Code { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isDiscrete.HasValue) this._isDiscrete = true;
                if (!this._isTotal.HasValue) this._isTotal = false;
                if (!this.isComprehensive.HasValue) this.isComprehensive = IsComprehensiveType.Unknown;
            }
        }
    }
}