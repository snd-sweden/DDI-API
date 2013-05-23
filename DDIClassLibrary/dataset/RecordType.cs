using System.Collections.Generic;

namespace DDIClassLibrary.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_1")]
    public class RecordType
    {
        public RecordType()
        {
            this.Value = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<string> Value { get; set; }
    }
}