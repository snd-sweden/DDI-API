using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class TextDomainType : TextRepresentationBaseType
    {
        public TextDomainType()
        {

        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ParameterType OutParameter { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ResponseCardinalityType ResponseCardinality { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ContentDateOffsetType ContentDateOffset { get; set; }
    }
}