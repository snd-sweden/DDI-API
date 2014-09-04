using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_2")]
    public class RecordSetType
    {
        public RecordSetType()
        {
            this.Record = new List<RecordType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public VariableOrderType VariableOrder { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<RecordType> Record { get; set; }
    }
}