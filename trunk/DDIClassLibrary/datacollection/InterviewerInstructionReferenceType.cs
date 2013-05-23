using System;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class InterviewerInstructionReferenceType : ReferenceType, IHaveDefaultValues
    {
        public InterviewerInstructionReferenceType()
        {

        }

        private Nullable<bool> _displayText;

        [System.Xml.Serialization.XmlAttribute()]
        public bool displayText
        {
            get
            {
                if (_displayText.HasValue)
                    return _displayText.Value;
                return true; //default value;
            }
            set
            {
                this._displayText = value;
            }
        }

        public bool ShouldSerializedisplayText()
        {
            return _displayText.HasValue;
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
                if (!this._displayText.HasValue) this._displayText = true;
            }
        }
    }
}