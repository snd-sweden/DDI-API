using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_2")]
    public class RecordType
    {
        public RecordType()
        {
            this.Value = new List<ValueType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = false, Order = 0)]
        public List<ValueType> Value { get; set; }
    }
}