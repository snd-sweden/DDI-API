using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class LocalHoldingPackageType : MaintainableType
    {
        public LocalHoldingPackageType()
        {
            this.DepositoryStudyUnitReference = new List<ReferenceType>();
            this.DepositoryGroupReference = new List<ReferenceType>();
            this.DepositoryResourcePackageReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<ReferenceType> DepositoryStudyUnitReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public List<ReferenceType> DepositoryGroupReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public List<ReferenceType> DepositoryResourcePackageReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public LocalAddedContentType LocalAddedContent { get; set; }
    }
}