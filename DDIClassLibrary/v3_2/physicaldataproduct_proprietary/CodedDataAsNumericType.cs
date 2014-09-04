using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_2")]
    public class CodedDataAsNumericType : ReferenceType, IHaveDefaultValues
    {
        public CodedDataAsNumericType()
        {

        }

        private Nullable<bool> _treatCodedDataAsNumeric;

        [System.Xml.Serialization.XmlAttribute()]
        public bool treatCodedDataAsNumeric
        {
            get
            {
                if (_treatCodedDataAsNumeric.HasValue)
                    return _treatCodedDataAsNumeric.Value;
                return true; //default value;
            }
            set
            {
                this._treatCodedDataAsNumeric = value;
            }
        }

        public bool ShouldSerializetreatCodedDataAsNumeric()
        {
            return _treatCodedDataAsNumeric.HasValue;
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this._treatCodedDataAsNumeric = true;
            }
        }
    }
}