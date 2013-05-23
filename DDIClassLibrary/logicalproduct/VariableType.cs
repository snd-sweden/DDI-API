using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariableType : VersionableType, IHaveDefaultValues
    {
        public VariableType()
        {
            this.ObjectType = "Variable";

            this.VariableName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
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

        [System.Xml.Serialization.XmlAttribute()]
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> QuestionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType EmbargoReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string ResponseUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 8)]
        public CodeValueType AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public RepresentationType Representation { get; set; }

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