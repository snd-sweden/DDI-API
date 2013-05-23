using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_1")]
    public class DataItemAddressType
    {
        public DataItemAddressType()
        {
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = false, Order = 0)]
        public List<StructuredStringType> Description { get; set; }
    }
}