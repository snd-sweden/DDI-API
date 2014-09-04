using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class PhysicalStructureReferenceType : ReferenceType
    {
        public PhysicalStructureReferenceType()
        {
        }

        [System.Xml.Serialization.XmlElement(DataType = "NCName", Order = 0)]
        public string PhysicalRecordSegmentUsed { get; set; }
    }
}