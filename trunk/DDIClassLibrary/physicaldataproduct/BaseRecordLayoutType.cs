using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public abstract class BaseRecordLayoutType : VersionableType
    {
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public PhysicalStructureReferenceType PhysicalStructureReference { get; set; }
    }
}