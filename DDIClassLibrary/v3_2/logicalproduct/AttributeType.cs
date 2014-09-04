using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class AttributeType : IdentifiableType
    {
        public AttributeType()
        {

        }

        private Nullable<AttachmentLevelCodeType> _attachmentLevel;

        [System.Xml.Serialization.XmlAttribute()]
        public AttachmentLevelCodeType attachmentLevel
        {
            get
            {
                if (_attachmentLevel.HasValue)
                    return _attachmentLevel.Value;
                return 0; //default value;
            }
            set
            {
                this._attachmentLevel = value;
            }
        }

        public bool ShouldSerializeclassificationLevel()
        {
            return _attachmentLevel.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string AttachmentValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType AttachmentRegionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public MeasureDefinitionReferenceType MeasureDefinitionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public DDIClassLibrary.v3_2.reusable.ValueType Value { get; set; }
    }
}