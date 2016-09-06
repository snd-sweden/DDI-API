using System.Collections.Generic;
using DDIClassLibrary.v3_1.group;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.instance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:instance:3_1")]
    [System.Xml.Serialization.XmlRoot("DDIInstance", Namespace = "ddi:instance:3_1", IsNullable = false)]
    public class DDIInstanceType : MaintainableType
    {
        [System.Xml.Serialization.XmlAttributeAttribute("schemaLocation", Namespace = System.Xml.Schema.XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "ddi:instance:3_1 http://www.ddialliance.org/Specification/DDI-Lifecycle/3.1/XMLSchema/instance.xsd";

        public DDIInstanceType()
        {
            this.ObjectType = "DDIInstance";

            this.Group = new List<GroupType>();
            this.ResourcePackage = new List<ResourcePackageType>();
            this.LocalHoldingPackage = new List<LocalHoldingPackageType>();
            this.StudyUnit = new List<DDIClassLibrary.v3_1.studyunit.StudyUnitType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 1)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_1", Order = 2)]
        public List<GroupType> Group { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_1", Order = 3)]
        public List<ResourcePackageType> ResourcePackage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_1", Order = 4)]
        public List<LocalHoldingPackageType> LocalHoldingPackage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:studyunit:3_1", Order = 5)]
        public List<DDIClassLibrary.v3_1.studyunit.StudyUnitType> StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:reusable:3_1", Order = 6)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:reusable:3_1", Order = 7)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public TranslationType TranslationInformation { get; set; }
    }
}