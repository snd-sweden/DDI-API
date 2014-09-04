using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class ContentLinkingMapType
    {
        public ContentLinkingMapType()
        {
            this.LinkingMap = new List<LinkingMapType>();   
        }
          
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<LinkingMapType> LinkingMap { get; set; }
             
    }
}