using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class ConceptualVariableGroupType : VersionableType, IHaveDefaultValues
    {
        public ConceptualVariableGroupType()
        {
            this.ConceptualVariableGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Subject = new List<InternationalCodeValueType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.ConceptualVariableReference = new List<ReferenceType>();
            this.ConceptualVariableGroupReference = new List<ReferenceType>();
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
        public CodeValueType TypeOfConceptualVariableGroup { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> ConceptualVariableGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<InternationalCodeValueType> Subject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<ReferenceType> ConceptualVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ReferenceType> ConceptualVariableGroupReference { get; set; }
        
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