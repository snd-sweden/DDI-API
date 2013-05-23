using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class NCubeType : VersionableType, IHaveDefaultValues
    {
        public NCubeType()
        {
            this.ObjectType = "NCube";

            this.NCubeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Purpose = new List<InternationalStringType>();
            this.Dimension = new List<DimensionType>();
            this.CoordinateGroup = new List<CoordinateGroupType>();
            this.Measure = new List<MeasureType>();
            this.Attribute = new List<AttributeType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int dimensionCount{ get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public int cellCount { get; set; }

        private Nullable<bool> _isClean;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isClean
        {
            get
            {
                if (_isClean.HasValue)
                    return _isClean.Value;
                return true; //default value;
            }
            set
            {
                this._isClean = value;
            }
        }

        public bool ShouldSerializeisClean()
        {
            return _isClean.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> NCubeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType ImputationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string ResponseUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 6)]
        public CodeValueType AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<InternationalStringType> Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 8)]
        public List<DimensionType> Dimension { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<CoordinateGroupType> CoordinateGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 10)]
        public List<MeasureType> Measure { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<AttributeType> Attribute { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isClean.HasValue) this._isClean = true;
            }
        }
    }
}