using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class ConceptGroupType : VersionableType, IHaveDefaultValues
    {
        public ConceptGroupType()
        {
            this.ConceptGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.GroupingUniverseReference = new List<ReferenceType>();
            this.Subject = new List<InternationalCodeValueType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.ConceptReference = new List<ReferenceType>();
            this.ConceptGroupReference = new List<ReferenceType>();

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

        private Nullable<bool> _isAdministrativeOnly;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isAdministrativeOnly
        {
            get
            {
                if (_isAdministrativeOnly.HasValue)
                    return _isAdministrativeOnly.Value;
                return false; //default value;
            }
            set
            {
                this._isAdministrativeOnly = value;
            }
        }
        
        public bool ShouldSerializeisAdministrativeOnly()
        {
            return _isAdministrativeOnly.HasValue;
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

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfConceptGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> ConceptGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> GroupingUniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType GroupingConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<InternationalCodeValueType> Subject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<ReferenceType> ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> ConceptGroupReference { get; set; }
        
        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
            {
                if (!_isOrdered.HasValue) _isOrdered = false;
                if (!_isAdministrativeOnly.HasValue) _isAdministrativeOnly = false;
                if (!_isConcept.HasValue) _isConcept = false;
            }
        }

    }
}