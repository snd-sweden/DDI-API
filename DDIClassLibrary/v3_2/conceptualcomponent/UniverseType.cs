using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class UniverseType : VersionableType, IHaveDefaultValues
    {
        public UniverseType()
        {
            this.UniverseName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseGenerationCode = new List<CommandCodeType>();
            this.SubUniverseClass = new List<SubUniverseClassType>();
            this.SubUniverseClassReference = new List<ReferenceType>();
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType DefiningConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<CommandCodeType> UniverseGenerationCode { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<SubUniverseClassType> SubUniverseClass { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> SubUniverseClassReference { get; set; }

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