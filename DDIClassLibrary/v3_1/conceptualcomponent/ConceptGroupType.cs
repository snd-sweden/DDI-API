using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class ConceptGroupType : VersionableType, IHaveDefaultValues
    {
        public ConceptGroupType()
        {
            this.ObjectType = "ConceptGroup";

            this.ConceptGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
        }

        private Nullable<bool> _isConcept;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isConcept
        {
            get
            {
                if (_isConcept.HasValue)
                    return _isConcept.Value;
                return false; //default value;
            }
            set
            {
                this._isConcept = value;
            }
        }

        public bool ShouldSerializeisConcept()
        {
            return _isConcept.HasValue;
        }

        private Nullable<bool> _isOrdered;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isOrdered
        {
            get
            {
                if (_isOrdered.HasValue)
                    return _isOrdered.Value;
                return false; //default value;
            }
            set
            {
                this._isOrdered = value;
            }
        }

        public bool ShouldSerializeisOrdered()
        {
            return _isOrdered.HasValue;
        }

        private Nullable<bool> _isStructured;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isStructured
        {
            get
            {
                if (_isStructured.HasValue)
                    return _isStructured.Value;
                return false; //default value;
            }
            set
            {
                this._isStructured = value;
            }
        }

        public bool ShouldSerializeisStructured()
        {
            return _isStructured.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ConceptGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> ConceptGroupReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CodeValueType AdministrativePurpose { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CodeValueType DefiningConceptReference { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isConcept.HasValue) this._isConcept = false;
                if (!this._isOrdered.HasValue) this._isOrdered = false;
                if (!this._isStructured.HasValue) this._isStructured = false;
            }
        }
    }
}