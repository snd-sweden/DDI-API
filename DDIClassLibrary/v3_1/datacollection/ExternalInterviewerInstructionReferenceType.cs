using System;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ExternalInterviewerInstructionReferenceType : OtherMaterialType, IHaveDefaultValues
    {
        public ExternalInterviewerInstructionReferenceType()
        {

        }

        private Nullable<bool> _isDisplayed;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isDisplayed
        {
            get
            {
                if (_isDisplayed.HasValue)
                    return _isDisplayed.Value;
                return true; //default value;
            }
            set
            {
                this._isDisplayed = value;
            }
        }

        public bool ShouldSerializeisDisplayed()
        {
            return _isDisplayed.HasValue;
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
                if (!this._isDisplayed.HasValue) this._isDisplayed = true;
            }
        }
    }
}