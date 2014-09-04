using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_2")]
    public class CodedDataAsTextType : ReferenceType, IHaveDefaultValues
    {
        public CodedDataAsTextType()
        {

        }

        private Nullable<bool> _treatCodedDataAsText;

        [System.Xml.Serialization.XmlAttribute()]
        public bool treatCodedDataAsText
        {
            get
            {
                if (_treatCodedDataAsText.HasValue)
                    return _treatCodedDataAsText.Value;
                return true; //default value;
            }
            set
            {
                this._treatCodedDataAsText = value;
            }
        }

        public bool ShouldSerializetreatCodedDataAsText()
        {
            return _treatCodedDataAsText.HasValue;
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this._treatCodedDataAsText = true;
            }
        }
    }
}