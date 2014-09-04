using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ControlConstructReferenceType : ReferenceType
    {
        public ControlConstructReferenceType()
        {
            this.Binding = new List<BindingType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<BindingType> Binding { get; set; }
    }
}