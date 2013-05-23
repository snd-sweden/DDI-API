using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class NCubeGroupType : VersionableType
    {
        public NCubeGroupType()
        {
            this.ObjectType = "NCubeGroup";

            this.NCubeGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.UniverseReference = new List<ReferenceType>();
            this.NCubeReference = new List<ReferenceType>();
            this.NCubeGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement("GroupType", typeof(CodeValueType), Order = 0)]
        [System.Xml.Serialization.XmlElement("GroupTypeCoded", typeof(GroupTypeCodedType), Order = 0)]
        public CodeValueType GroupType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> NCubeGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> NCubeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> NCubeGroupReference { get; set; }
    }
}