using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class VariableType : VersionableType, IHaveDefaultValues
    {
        public VariableType()
        {
            this.VariableName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.SourceVariableReference = new List<ReferenceType>();
            this.UniverseReference = new List<ReferenceType>();
            this.QuestionReference = new List<ReferenceType>();
        }

        private Nullable<bool> _isTemporal;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isTemporal
        {
            get
            {
                if (_isTemporal.HasValue)
                    return _isTemporal.Value;
                return false; //default value;
            }
            set
            {
                this._isTemporal = value;
            }
        }

        public bool ShouldSerializeisTemporal()
        {
            return _isTemporal.HasValue;
        }

        private Nullable<bool> _isGeographic;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isGeographic
        {
            get
            {
                if (_isGeographic.HasValue)
                    return _isGeographic.Value;
                return false; //default value;
            }
            set
            {
                this._isGeographic = value;
            }
        }

        public bool ShouldSerializeisGeographic()
        {
            return _isGeographic.HasValue;
        }

        private Nullable<bool> _isWeight;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isWeight
        {
            get
            {
                if (_isWeight.HasValue)
                    return _isWeight.Value;
                return false; //default value;
            }
            set
            {
                this._isWeight = value;
            }
        }

        public bool ShouldSerializeisWeight()
        {
            return _isWeight.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> VariableName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ParameterType OutParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public ReferenceType SourceParameterReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> SourceVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType RepresentedVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public ReferenceType ConceptualVariableReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 10)]
        public List<ReferenceType> QuestionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 11)]
        public ReferenceType EmbargoReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 12)]
        public CodeValueType SourceUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 13)]
        public CodeValueType AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 14)]
        public VariableRepresentationType VariableRepresentation { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isGeographic.HasValue) this._isGeographic = false;
                if (!this._isTemporal.HasValue) this._isTemporal = false;
                if (!this._isWeight.HasValue) this._isWeight = false;
            }
        }
    }
}