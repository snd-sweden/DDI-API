using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LifecycleInformationType
    {
        public LifecycleInformationType()
        {
            this.LifecycleEvent = new List<LifecycleEventType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LifecycleEventType> LifecycleEvent { get; set; }
    }
}