using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class RecordLayoutSchemeType : MaintainableType
    {
        public RecordLayoutSchemeType()
        {
            this.ObjectType = "RecordLayoutScheme";

            this.RecordLayoutSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.RecordLayoutSchemeReference = new List<SchemeReferenceType>();
            this.BaseRecordLayout = new List<BaseRecordLayoutType>();
            this.RecordLayoutItems = new List<BaseRecordLayoutType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RecordLayoutSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> RecordLayoutSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement("DataSet", typeof(DDIClassLibrary.dataset.DataSetType), IsNullable = true, Order = 4)]
        [System.Xml.Serialization.XmlElement("ProprietaryRecordLayout", typeof(DDIClassLibrary.physicaldataproduct_proprietary.ProprietaryRecordLayoutType), IsNullable = true, Order = 4)]
        public List<BaseRecordLayoutType> BaseRecordLayout { get; set; }

        [System.Xml.Serialization.XmlElement("RecordLayout", IsNullable = true, Order = 5)]
        public List<BaseRecordLayoutType> RecordLayoutItems { get; set; }
    }
}