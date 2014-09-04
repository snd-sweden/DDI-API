using System.Collections.Generic;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_2")]
    public class DataSetType : BaseRecordLayoutType
    {
        public DataSetType()
        {
            this.DatasetName = new List<NameType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public int ArrayBase { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> DatasetName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType IdentifyingVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public SchemeReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public RecordSetType RecordSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ItemSetType ItemSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public VariableSetType VariableSet { get; set; }
    }
}