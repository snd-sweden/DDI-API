using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_2")]
    public class ItemSetType
    {
        public ItemSetType()
        {
            this.ItemValue = new List<ItemValueType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<ItemValueType> ItemValue { get; set; }
    }
}