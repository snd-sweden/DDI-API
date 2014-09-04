using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
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