using System.Collections.Generic;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class StatementItemType : ControlConstructType
    {
        public StatementItemType()
        {
            this.ObjectType = "StatementItem";
            
            this.DisplayText = new List<DynamicTextType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<DynamicTextType> DisplayText { get; set; }
    }
}