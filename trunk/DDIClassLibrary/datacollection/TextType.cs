using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public abstract class TextType
    {
        public TextType()
        {
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 0)]
        public List<StructuredStringType> Description { get; set; }
    }
}