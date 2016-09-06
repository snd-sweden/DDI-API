using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using DDIClassLibrary.v3_2.group;
using DDIClassLibrary.v3_2.studyunit;
using DDIClassLibrary.v3_2.ddiprofile;

namespace DDIClassLibrary.v3_2.instance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:instance:3_2")]
    [System.Xml.Serialization.XmlRoot("DDIInstance", Namespace = "ddi:instance:3_2", IsNullable = false)]
    public class DDIInstanceType : MaintainableType
    {
        [System.Xml.Serialization.XmlAttributeAttribute("schemaLocation", Namespace = System.Xml.Schema.XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "ddi:instance:3_2 http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/instance.xsd";

        public DDIInstanceType()
        {
            this.Group = new List<GroupType>();
            this.GroupReference = new List<ReferenceType>();
            this.ResourcePackage = new List<ResourcePackageType>();
            this.ResourcePackageReference = new List<ReferenceType>();
            this.LocalHoldingPackage = new List<LocalHoldingPackageType>();
            this.LocalHoldingPackageReference = new List<ReferenceType>();
            this.StudyUnit = new List<StudyUnitType>();
            this.StudyUnitReference = new List<ReferenceType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_2", Order = 2)]
        public List<GroupType> Group { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public List<ReferenceType> GroupReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_2", Order = 4)]
        public List<ResourcePackageType> ResourcePackage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public List<ReferenceType> ResourcePackageReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:group:3_2", Order = 6)]
        public List<LocalHoldingPackageType> LocalHoldingPackage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public List<ReferenceType> LocalHoldingPackageReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:studyunit:3_2", Order = 8)]
        public List<StudyUnitType> StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public List<ReferenceType> StudyUnitReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:reusable:3_2", Order = 10)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:ddiprofile:3_2", Order = 11)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 12)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 13)]
        public TranslationType TranslationInformation { get; set; }

    }
}