using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class CodeListType : MaintainableType, IHaveDefaultValues
    {
        public CodeListType()
        {
            this.CodeListName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.CodeListReference = new List<ReferenceType>();
            this.Level = new List<LevelType>();
            this.Code = new List<CodeType>();
        }

        private Nullable<bool> _isSystemMissingValue;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isSystemMissingValue
        {
            get
            {
                if (_isSystemMissingValue.HasValue)
                    return _isSystemMissingValue.Value;
                return false; //default value;
            }
            set
            {
                this._isSystemMissingValue = value;
            }
        }

        public bool ShouldSerializeisSystemMissingValue()
        {
            return _isSystemMissingValue.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CodeListName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ReferenceType> CodeListReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public SchemeReferenceType CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public HierarchyCodeType HierarchyType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<LevelType> Level { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<CodeType> Code { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
            {
                if (!this._isSystemMissingValue.HasValue) this._isSystemMissingValue = false;
            }
        }
    }
}