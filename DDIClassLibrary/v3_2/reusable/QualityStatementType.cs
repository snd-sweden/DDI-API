using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class QualityStatementType : VersionableType
    {
        public QualityStatementType()
        {
            this.QualityStatementName = new List<NameType>();
            this.Label = new List<LabelType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QualityStatementName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StandardType Standard { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public StructuredStringType OtherQualityStatement { get; set; }

    }
}