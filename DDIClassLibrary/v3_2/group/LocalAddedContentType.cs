using DDIClassLibrary.v3_2.studyunit;
using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class LocalAddedContentType
    {
        public LocalAddedContentType()
        {
            this.LocalStudyUnitContent = new List<StudyUnitType>();
            this.LocalStudyUnitContentReference = new List<ReferenceType>();
            this.LocalGroupContent = new List<GroupType>();
            this.LocalGroupContentReference = new List<ReferenceType>();
            this.LocalResourcePackageContent = new List<ResourcePackageType>();
            this.LocalResourcePackageContentReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ContentLinkingMapType ContentLinkingMap { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StudyUnitType> LocalStudyUnitContent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ReferenceType> LocalStudyUnitContentReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<GroupType> LocalGroupContent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> LocalGroupContentReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ResourcePackageType> LocalResourcePackageContent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> LocalResourcePackageContentReference { get; set; }
    }
}