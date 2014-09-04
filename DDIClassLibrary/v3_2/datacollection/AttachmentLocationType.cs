using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class AttachmentLocationType
    {
        public AttachmentLocationType()
        {
            this.CodeReference = new List<ReferenceType>();
            this.CategoryReference = new List<ReferenceType>();
            this.DomainSpecificValue = new List<DomainSpecificValueType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<ReferenceType> CodeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<ReferenceType> CategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<DomainSpecificValueType> DomainSpecificValue { get; set; }
    }
}