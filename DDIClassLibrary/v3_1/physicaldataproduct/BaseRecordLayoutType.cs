using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public abstract class BaseRecordLayoutType : VersionableType
    {
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public PhysicalStructureReferenceType PhysicalStructureReference { get; set; }
    }
}