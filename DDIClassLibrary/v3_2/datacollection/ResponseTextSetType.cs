using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ResponseTextSetType
    {
        public ResponseTextSetType()
        {
            this.ResponseText = new List<DynamicTextType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<DynamicTextType> ResponseText { get; set; }

    }
}