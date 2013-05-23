using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class ConceptType : VersionableType, IHaveDefaultValues
    {
        public ConceptType()
        {
            this.ObjectType = "Concept";

            this.ConceptName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.SimilarConcept = new List<SimilarConceptType>();
        }

        private Nullable<bool> _isCharacteristic;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isCharacteristic
        {
            get
            {
                if (_isCharacteristic.HasValue)
                    return _isCharacteristic.Value;
                return false; //default value;
            }
            set
            {
                this._isCharacteristic = value;
            }
        }

        public bool ShouldSerializeisCharacteristic()
        {
            return _isCharacteristic.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<SimilarConceptType> SimilarConcept { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isCharacteristic.HasValue) this._isCharacteristic = false;
            }
        }
    }
}