using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RelatedLocationValueReferenceType : ReferenceType, IHaveDefaultValues
    {
        public RelatedLocationValueReferenceType()
        {

        }

        private Nullable<bool> _isFull;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isFull
        {
            get
            {
                if (_isFull.HasValue)
                    return _isFull.Value;
                return false; //default value;
            }
            set
            {
                this._isFull = value;
            }
        }

        public bool ShouldSerializeisFull()
        {
            return _isFull.HasValue;
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if(!this._isFull.HasValue) this._isFull = false;
            }
        }
    }
}