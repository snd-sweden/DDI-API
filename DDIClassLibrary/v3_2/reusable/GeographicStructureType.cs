using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class GeographicStructureType : VersionableType
    {
        public GeographicStructureType()
        {
            this.GeographicStructureName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.AuthorizedSource = new List<AuthorizedSourceType>();
            this.GeographicLevel = new List<GeographicLevelType>();
            this.GeographicLevelReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> GeographicStructureName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<AuthorizedSourceType> AuthorizedSource { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<GeographicLevelType> GeographicLevel { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> GeographicLevelReference { get; set; }

    }
}