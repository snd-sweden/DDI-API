using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class RecordLayoutSchemeType : MaintainableType
    {
        public RecordLayoutSchemeType()
        {
            this.RecordLayoutSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.RecordLayoutSchemeReference = new List<SchemeReferenceType>();
            this.BaseRecordLayout = new List<BaseRecordLayoutType>();
            this.RecordLayoutReference = new List<ReferenceType>();
            this.RecordLayoutGroup = new List<RecordLayoutGroupType>();
            this.RecordLayoutGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RecordLayoutSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> RecordLayoutSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement("DataSet", typeof(DDIClassLibrary.v3_2.dataset.DataSetType), IsNullable = true, Order = 4)]
        [System.Xml.Serialization.XmlElement("RecordLayout", typeof(DDIClassLibrary.v3_2.physicaldataproduct.RecordLayoutType), IsNullable = true, Order = 4)]
        //[System.Xml.Serialization.XmlElement("RecordLayout", typeof(DDIClassLibrary.v3_2.physicaldataproduct_ncube_inline.RecordLayoutType), IsNullable = true, Order = 4)]
        //[System.Xml.Serialization.XmlElement("RecordLayout", typeof(DDIClassLibrary.v3_2.physicaldataproduct_ncube_normal.RecordLayoutType), IsNullable = true, Order = 4)]
        //[System.Xml.Serialization.XmlElement("RecordLayout", typeof(DDIClassLibrary.v3_2.physicaldataproduct_ncube_tabular.RecordLayoutType), IsNullable = true, Order = 4)]
        //[System.Xml.Serialization.XmlElement("RecordLayout", typeof(DDIClassLibrary.v3_2.physicaldataproduct_proprietary.RecordLayoutType), IsNullable = true, Order = 4)]
        public List<BaseRecordLayoutType> BaseRecordLayout { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> RecordLayoutReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<RecordLayoutGroupType> RecordLayoutGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> RecordLayoutGroupReference { get; set; }
    }
}