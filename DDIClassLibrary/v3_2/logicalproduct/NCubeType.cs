using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class NCubeType : VersionableType, IHaveDefaultValues
    {
        public NCubeType()
        {
            this.NCubeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();            
            this.Dimension = new List<DimensionType>();
            this.CoordinateRegion = new List<CoordinateRegionType>();
            this.MeasureDefinition = new List<MeasureDefinitionType>();
            this.Attribute = new List<AttributeType>();
        }

        private Nullable<int> _dimensionCount;

        [System.Xml.Serialization.XmlAttribute()]
        public int dimensionCount
        {
            get
            {
                if (_dimensionCount.HasValue)
                    return _dimensionCount.Value;
                return 0; //default value;
            }
            set
            {
                this._dimensionCount = value;
            }
        }

        public bool ShouldSerializedimensionCount()
        {
            return _dimensionCount.HasValue;
        }

        private Nullable<int> _cellCount;

        [System.Xml.Serialization.XmlAttribute()]
        public int cellCount
        {
            get
            {
                if (_cellCount.HasValue)
                    return _cellCount.Value;
                return 0; //default value;
            }
            set
            {
                this._cellCount = value;
            }
        }

        public bool ShouldSerializecellCount()
        {
            return _cellCount.HasValue;
        }

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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType ImputationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CodeValueType SourceUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public CodeValueType AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public StructuredStringType Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<DimensionType> Dimension { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<CoordinateRegionType> CoordinateRegion { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<MeasureDefinitionType> MeasureDefinition { get; set; }

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