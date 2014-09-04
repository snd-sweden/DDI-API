using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class LevelType
    {
        public LevelType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int levelNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CategoryRelationCodeType RelationshipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public IntervalType Interval { get; set; }
    }
}