using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class StatementItemType : ControlConstructType
    {
        public StatementItemType()
        {
            this.DisplayText = new List<DynamicTextType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<DynamicTextType> DisplayText { get; set; }
    }
}