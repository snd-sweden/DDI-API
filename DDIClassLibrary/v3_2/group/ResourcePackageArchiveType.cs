using DDIClassLibrary.v3_2.reusable;
using DDIClassLibrary.v3_2.archive;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class ResourcePackageArchiveType
    {
        public ResourcePackageArchiveType()
        {
            this.Archive = new List<ArchiveType>();
            this.ArchiveReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_2", Order = 0)]
        public List<ArchiveType> Archive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public List<ReferenceType> ArchiveReference { get; set; }
    }
}