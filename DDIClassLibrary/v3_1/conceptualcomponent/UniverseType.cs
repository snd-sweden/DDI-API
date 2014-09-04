using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class UniverseType : VersionableType, IHaveDefaultValues
    {
        public UniverseType()
        {
            this.ObjectType = "Universe";

            this.UniverseName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.HumanReadable = new List<StructuredStringType>();
            this.MachineReadable = new List<CodeType>();
            this.SubUniverse = new List<UniverseType>();
        }

        private Nullable<bool> _isInclusive;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isInclusive
        {
            get
            {
                if (_isInclusive.HasValue)
                    return _isInclusive.Value;
                return true; //default value;
            }
            set
            {
                this._isInclusive = value;
            }
        }

        public bool ShouldSerializeisInclusive()
        {
            return _isInclusive.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> UniverseName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> HumanReadable { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CodeType> MachineReadable { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<UniverseType> SubUniverse { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isInclusive.HasValue) this._isInclusive = false;
            }
        }
    }
}