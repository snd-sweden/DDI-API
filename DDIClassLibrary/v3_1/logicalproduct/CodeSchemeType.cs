using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CodeSchemeType : MaintainableType
    {
        public CodeSchemeType()
        {
            this.ObjectType = "CodeScheme";

            this.CodeSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.CodeSchemeReference = new List<ReferenceType>();
            this.Level = new List<LevelType>();
            this.Code = new List<CodeType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CodeSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> CodeSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public HierarchyCodeType HierarchyType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<LevelType> Level { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<CodeType> Code { get; set; }
    }
}