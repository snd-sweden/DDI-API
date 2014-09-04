using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ProprietaryInfoType
    {
        public ProprietaryInfoType()
        {
            this.ProprietaryProperty = new List<StandardKeyValuePairType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<StandardKeyValuePairType> ProprietaryProperty { get; set; }
    }
}