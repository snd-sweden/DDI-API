using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class ArchiveType : MaintainableType
    {
        public ArchiveType()
        {
            this.ObjectType = "Archive";

            this.ArchiveModuleName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ArchiveSpecific = new ArchiveSpecificType();
            this.OrganizationScheme = new OrganizationSchemeType();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ArchiveModuleName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ArchiveSpecificType ArchiveSpecific { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public OrganizationSchemeType OrganizationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 5)]
        public LifecycleInformationType LifecycleInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 6)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 7)]
        public List<NoteType> Note { get; set; }
    }
}