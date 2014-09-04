using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.physicaldataproduct;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_1")]
    public class ProprietaryRecordLayoutType : BaseRecordLayoutType
    {
        public ProprietaryRecordLayoutType()
        {
            this.ObjectType = "ProprietaryRecordLayout";

            this.DataItem = new List<DataItemType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public SoftwareType Software { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public DataItemAddressType DataItemAddress { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public NumericRepresentationType DefaultNumericDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public TextRepresentationType DefaultTextDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public DateTimeRepresentationType DefaultDateTimeDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public NumericRepresentationType CodedDataAsNumeric { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public TextRepresentationType CodedDataAsText { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public ReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 10)]
        public ProprietaryInfoType ProprietaryInfo { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<DataItemType> DataItem { get; set; }
    }
}