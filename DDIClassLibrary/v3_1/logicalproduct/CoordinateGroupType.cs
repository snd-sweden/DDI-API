using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CoordinateGroupType : IdentifiableType
    {
        public CoordinateGroupType()
        {
            this.ObjectType = "CoordinateGroup";

            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Definition = new List<StructuredStringType>();
            this.DimensionValue = new List<CohortType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 0)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Definition { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 3)]
        public List<CohortType> DimensionValue { get; set; }
    }
}