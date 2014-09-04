using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class LogicalProductType : BaseLogicalProductType
    {
        public LogicalProductType()
        {
            this.CategoryScheme = new List<CategorySchemeType>();
            this.CategorySchemeReference = new List<SchemeReferenceType>();
            this.CodeListScheme = new List<CodeListSchemeType>();
            this.CodeListSchemeReference = new List<SchemeReferenceType>();
            this.ManagedRepresentationScheme = new List<ManagedRepresentationSchemeType>();
            this.ManagedRepresentationSchemeReference = new List<SchemeReferenceType>();
            this.RepresentedVariableScheme = new List<RepresentedVariableSchemeType>();
            this.RepresentedVariableSchemeReference = new List<SchemeReferenceType>();
            this.VariableScheme = new List<VariableSchemeType>();
            this.VariableSchemeReference = new List<SchemeReferenceType>();
            this.NCubeScheme = new List<NCubeSchemeType>();
            this.NCubeSchemeReference = new List<SchemeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<CategorySchemeType> CategoryScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<SchemeReferenceType> CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CodeListSchemeType> CodeListScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> CodeListSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ManagedRepresentationSchemeType> ManagedRepresentationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<SchemeReferenceType> ManagedRepresentationSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<RepresentedVariableSchemeType> RepresentedVariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<SchemeReferenceType> RepresentedVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<VariableSchemeType> VariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 9)]
        public List<SchemeReferenceType> VariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<NCubeSchemeType> NCubeScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 11)]
        public List<SchemeReferenceType> NCubeSchemeReference { get; set; }
    }
}