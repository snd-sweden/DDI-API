using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class PhysicalDataProductType
    {
        public PhysicalDataProductType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", Order = 0)]
        public DDIClassLibrary.physicaldataproduct.PhysicalDataProductType PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}