using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class RecordRelationshipType : IdentifiableType, IHaveDefaultValues
    {
        public RecordRelationshipType()
        {
            this.ObjectType = "RecordRelationship";

            this.RecordRelationshipName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public Nullable<ValueTypeCodeType> type { get; set; }

        public bool ShouldSerializetype()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "type")]
        public string typeValue
        {
            get
            {
                if (type.HasValue)
                    return type.ToString();
                return null;
            }
            set
            {
                ValueTypeCodeType result;
                Enum.TryParse<ValueTypeCodeType>(value, out result);
                type = result;
            }
        }

        public bool ShouldSerializetypeValue()
        {
            return this.type.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> RecordRelationshipName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public RecordReferenceSourceType RecordReferenceSource { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType RecordReferenceTarget { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this.type.HasValue) this.type = ValueTypeCodeType.Equal;
            }
        }
    }
}