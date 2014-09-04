using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class RecordRelationshipType : IdentifiableType, IHaveDefaultValues
    {
        public RecordRelationshipType()
        {
            this.RecordRelationshipName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.SourceTargetLink = new List<SourceTargetLinkType>();
        }

        private Nullable<RelationCodeType> _relationToTarget;

        [System.Xml.Serialization.XmlAttribute()]
        public RelationCodeType relationToTarget
        {
            get
            {
                if (_relationToTarget.HasValue)
                    return _relationToTarget.Value;
                return 0; //default value;
            }
            set
            {
                this._relationToTarget = value;
            }
        }

        public bool ShouldSerializerelationToTarget()
        {
            return _relationToTarget.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> RecordRelationshipName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType SourceLogicalRecordReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType TargetLogicalRecordReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<SourceTargetLinkType> SourceTargetLink { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
            {
                if (!this._relationToTarget.HasValue) this._relationToTarget = RelationCodeType.Unknown;
            }
        }
    }
}