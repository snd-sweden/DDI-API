using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class GeneralInstructionType : IHaveDefaultValues
    {
        public GeneralInstructionType()
        {
            this.CommandCode = new List<CommandCodeType>();
        }

        private Nullable<bool> _isOverride;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isOverride
        {
            get
            {
                if (_isOverride.HasValue)
                    return _isOverride.Value;
                return false; //default value;
            }
            set
            {
                this._isOverride = value;
            }
        }

        public bool ShouldSerializeisOverride()
        {
            return _isOverride.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<CommandCodeType> CommandCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType OverriddenCodeReference { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isOverride.HasValue) this._isOverride = false;
            }
        }
    }
}