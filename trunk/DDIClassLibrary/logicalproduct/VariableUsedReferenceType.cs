using System;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariableUsedReferenceType : ReferenceType, IHaveDefaultValues
    {
        public VariableUsedReferenceType()
        {

        }

        private Nullable<bool> _isExcluded;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isExcluded
        {
            get
            {
                if (_isExcluded.HasValue)
                    return _isExcluded.Value;
                return false; //default value;
            }
            set
            {
                this._isExcluded = value;
            }
        }

        public bool ShouldSerializeisExcluded()
        {
            return _isExcluded.HasValue;
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isExcluded.HasValue) this._isExcluded = false;
            }
        }
    }
}