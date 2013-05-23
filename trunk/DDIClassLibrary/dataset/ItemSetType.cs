using System.Collections.Generic;

namespace DDIClassLibrary.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_1")]
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