using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class DefaultMissingValuesReferenceType : ReferenceType, IHaveDefaultValues
    {
        public DefaultMissingValuesReferenceType()
        {

        }

        private Nullable<bool> _isSystemMissingValue;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isSystemMissingValue
        {
            get
            {
                if (_isSystemMissingValue.HasValue)
                    return _isSystemMissingValue.Value;
                return true; //default value;
            }
            set
            {
                this._isSystemMissingValue = value;
            }
        }

        public bool ShouldSerializeisSystemMissingValue()
        {
            return _isSystemMissingValue.HasValue;
        }


        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
                if (!_isSystemMissingValue.HasValue) _isSystemMissingValue = true;
        }
    }
}