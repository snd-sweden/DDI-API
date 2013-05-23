using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariableSchemeType : MaintainableType
    {
        public VariableSchemeType()
        {
            this.ObjectType = "VariableScheme";

            this.VariableSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.VariableSchemeReference = new List<ReferenceType>();
            this.Variable = new List<VariableType>();
            this.VariableReference = new List<ReferenceType>();
            this.VariableGroup = new List<VariableGroupType>();
            this.VariableGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> VariableSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> VariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<VariableType> Variable { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<VariableGroupType> VariableGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> VariableGroupReference { get; set; }
    }
}