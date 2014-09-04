using System;
using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InterviewerInstructionReferenceType : ReferenceType, IHaveDefaultValues
    {
        public InterviewerInstructionReferenceType()
        {
            this.InstructionAttachmentLocation = new List<InstructionAttachmentLocationType>();
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

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InstructionAttachmentLocationType> InstructionAttachmentLocation { get; set; }
        
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