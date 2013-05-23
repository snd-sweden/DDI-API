using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class GeneralInstructionType : IHaveDefaultValues
    {
        public GeneralInstructionType()
        {
            this.Description = new List<StructuredStringType>();
            this.Command = new List<CommandType>();
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = false, Order = 0)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<CommandType> Command { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType IsOverride { get; set; }

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