using System.Collections.Generic;
using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ManagedRepresentationGroupType : VersionableType, IHaveDefaultValues
    {
        public ManagedRepresentationGroupType()
        {
            this.ManagedRepresentationGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Subject = new List<InternationalCodeValueType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.ManagedDateTimeRepresentationReference = new List<ReferenceType>();
            this.ManagedMissingValuesRepresentationReference = new List<ReferenceType>();
            this.ManagedNumericRepresentationReference = new List<ReferenceType>();
            this.ManagedScaleRepresentationReference = new List<ReferenceType>();
            this.ManagedTextRepresentationReference = new List<ReferenceType>();
            this.CategorySchemeReference = new List<SchemeReferenceType>();
            this.CodeListReference = new List<ReferenceType>();
            this.GeographicStructureSchemeReference = new List<SchemeReferenceType>();
            this.GeographicLocationReference = new List<ReferenceType>();
            this.ManagedRepresentationGroupReference = new List<ReferenceType>();
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

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfManagedRepresentationGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> ManagedRepresentationGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<InternationalCodeValueType> Subject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> ManagedDateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> ManagedMissingValuesRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ReferenceType> ManagedNumericRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<ReferenceType> ManagedScaleRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<ReferenceType> ManagedTextRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<SchemeReferenceType> CategorySchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<ReferenceType> CodeListReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 15)]
        public List<SchemeReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ReferenceType> GeographicLocationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 17)]
        public List<ReferenceType> ManagedRepresentationGroupReference { get; set; }
        
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
            }
        }

    }
}