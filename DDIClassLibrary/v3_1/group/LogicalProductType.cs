using DDIClassLibrary.v3_1.logicalproduct;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class LogicalProductType
    {
        public LogicalProductType()
        {
        }

        [System.Xml.Serialization.XmlElement("BaseLogicalProduct", typeof(BaseLogicalProductType), Namespace = "ddi:logicalproduct:3_1", Order = 0)]
        [System.Xml.Serialization.XmlElement("LogicalProduct", typeof(DDIClassLibrary.v3_1.logicalproduct.LogicalProductType), Namespace = "ddi:logicalproduct:3_1", Order = 0)]
        [System.Xml.Serialization.XmlElement("NCubeLogicalProduct", typeof(NCubeLogicalProductType), Namespace = "ddi:logicalproduct:3_1", Order = 0)]
        public BaseLogicalProductType BaseLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}