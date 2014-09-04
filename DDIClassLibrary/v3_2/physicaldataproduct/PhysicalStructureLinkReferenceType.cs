using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class PhysicalStructureLinkReferenceType : ReferenceType
    {
        public PhysicalStructureLinkReferenceType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IDType PhysicalRecordSegmentUsed { get; set; }
    }
}