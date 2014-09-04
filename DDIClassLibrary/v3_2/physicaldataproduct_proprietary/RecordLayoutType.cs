using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_2")]
    public class RecordLayoutType : BaseRecordLayoutType
    {
        public RecordLayoutType()
        {
            this.DataItem = new List<DataItemType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public SoftwareType SystemSoftware { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public DataItemAddressType DataItemAddress { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType DefaultNumericDataTypeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType DefaultTextDataTypeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType DefaultDateTimeDataTypeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public CodedDataAsNumericType CodedDataAsNumeric { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public CodedDataAsTextType CodedDataAsText { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 10)]
        public SchemeReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 11)]
        public ProprietaryInfoType ProprietaryInfo { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<DataItemType> DataItem { get; set; }
    }
}