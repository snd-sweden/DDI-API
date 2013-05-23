using System.Collections.Generic;
using DDIClassLibrary.physicaldataproduct;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_1")]
    public class DataSetType : BaseRecordLayoutType
    {
        public DataSetType()
        {
            this.ObjectType = "DataSet";

            this.Name = new List<InternationalStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public int ArrayBase { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<InternationalStringType> Name { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType IdentifyingVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public RecordSetType RecordSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ItemSetType ItemSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public VariableSetType VariableSet { get; set; }
    }
}