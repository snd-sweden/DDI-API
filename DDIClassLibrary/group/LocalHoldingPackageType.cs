using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class LocalHoldingPackageType : MaintainableType
    {
        public LocalHoldingPackageType()
        {
            this.ObjectType = "LocalHoldingPackage";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType DepositoryStudyUnitReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType DepositoryGroupReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DDIClassLibrary.studyunit.StudyUnitType LocalAddedContent { get; set; }
    }
}