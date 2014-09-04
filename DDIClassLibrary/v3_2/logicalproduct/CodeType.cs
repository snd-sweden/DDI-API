using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class CodeType : IdentifiableType, IHaveDefaultValues
    {
        public CodeType()
        {
            this.Code = new List<CodeType>();
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

        private Nullable<int> _levelNumber;

        [System.Xml.Serialization.XmlAttribute()]
        public int levelNumber
        {
            get
            {
                if (_levelNumber.HasValue)
                    return _levelNumber.Value;
                return 0; //default value;
            }
            set
            {
                this._levelNumber = value;
            }
        }

        public bool ShouldSerializelevelNumber()
        {
            return _levelNumber.HasValue;
        }

        private Nullable<IsComprehensiveType> _isComprehensive;

        [System.Xml.Serialization.XmlAttribute()]
        public IsComprehensiveType isComprehensive
        {
            get
            {
                if (_isComprehensive.HasValue)
                    return _isComprehensive.Value;
                return IsComprehensiveType.Unknown; //default value;
            }
            set
            {
                this._isComprehensive = value;
            }
        }

        public bool ShouldSerializeisComprehensive()
        {
            return _isComprehensive.HasValue;
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


        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", Order = 0)]
        public ReferenceType CategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", Order = 1)]
        public DDIClassLibrary.v3_2.reusable.ValueType Value { get; set; }

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
                if (!this._isComprehensive.HasValue) this._isComprehensive = IsComprehensiveType.Unknown;
            }
        }
    }
}