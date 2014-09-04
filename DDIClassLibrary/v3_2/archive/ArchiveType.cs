using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class ArchiveType : MaintainableType
    {
        public ArchiveType()
        {
            this.ArchiveModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ArchiveSpecific = new List<ArchiveSpecificType>();
            this.OrganizationScheme = new List<OrganizationSchemeType>();
            this.OrganizationSchemeReference = new List<SchemeReferenceType>();
            this.OtherMaterial = new List<OtherMaterialType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ArchiveModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ArchiveSpecificType> ArchiveSpecific { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<OrganizationSchemeType> OrganizationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<SchemeReferenceType> OrganizationSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 6)]
        public LifecycleInformationType LifecycleInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<OtherMaterialType> OtherMaterial { get; set; }
    }
}