using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ProprietaryInfoType
    {
        public ProprietaryInfoType()
        {
            this.ProprietaryProperty = new List<ProprietaryPropertyType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<ProprietaryPropertyType> ProprietaryProperty { get; set; }
    }
}