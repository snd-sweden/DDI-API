using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public abstract class BaseRecordLayoutType : VersionableType
    {
        private Nullable<TextQualifierType> _textQualifier;

        [System.Xml.Serialization.XmlAttribute()]
        public TextQualifierType textQualifier
        {
            get
            {
                if (_textQualifier.HasValue)
                    return _textQualifier.Value;
                return 0; //default value;
            }
            set
            {
                this._textQualifier = value;
            }
        }

        public bool ShouldSerializetextQualifier()
        {
            return _textQualifier.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public PhysicalStructureLinkReferenceType PhysicalStructureLinkReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType EndOfLineMarker { get; set; }
    }
}