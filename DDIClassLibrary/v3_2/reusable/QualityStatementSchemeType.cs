using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class QualityStatementSchemeType : MaintainableType
    {
        public QualityStatementSchemeType()
        {
            this.QualityStatementSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.QualityStatementSchemeReference = new List<SchemeReferenceType>();
            this.QualityStatement = new List<QualityStatementType>();
            this.QualityStatementReference = new List<ReferenceType>();
            this.QualityStatementGroup = new List<QualityStatementGroupType>();
            this.QualityStatementGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> QualityStatementSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> QualityStatementSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<QualityStatementType> QualityStatement { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> QualityStatementReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<QualityStatementGroupType> QualityStatementGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> QualityStatementGroupReference { get; set; }
    }
}