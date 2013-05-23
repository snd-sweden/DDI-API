using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class LifecycleInformationType
    {
        public LifecycleInformationType()
        {
            this.LifecycleEvent = new List<LifecycleEventType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<LifecycleEventType> LifecycleEvent { get; set; }
    }
}