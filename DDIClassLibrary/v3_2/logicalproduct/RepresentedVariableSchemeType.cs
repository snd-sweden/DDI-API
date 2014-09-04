using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class RepresentedVariableSchemeType : MaintainableType
    {
        public RepresentedVariableSchemeType()
        {
            this.RepresentedVariableSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.RepresentedVariableSchemeReference = new List<SchemeReferenceType>();
            this.RepresentedVariable = new List<RepresentedVariableType>();
            this.RepresentedVariableReference = new List<ReferenceType>();
            this.RepresentedVariableGroup = new List<RepresentedVariableGroupType>();
            this.RepresentedVariableGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RepresentedVariableSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<SchemeReferenceType> RepresentedVariableSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<RepresentedVariableType> RepresentedVariable { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> RepresentedVariableReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<RepresentedVariableGroupType> RepresentedVariableGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> RepresentedVariableGroupReference { get; set; }
    }
}