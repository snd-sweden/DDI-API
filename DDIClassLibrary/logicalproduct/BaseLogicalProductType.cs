﻿using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public abstract class BaseLogicalProductType : MaintainableType
    {
        public BaseLogicalProductType()
        {
            this.ObjectType = "BaseLogicalProduct";

            this.LogicalProductName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.DataRelationship = new List<DataRelationshipType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.CategoryScheme = new List<CategorySchemeType>();
            this.CategorySchemeReference = new List<ReferenceType>();
            this.CodeScheme = new List<CodeSchemeType>();
            this.CodeSchemeReference = new List<ReferenceType>();
            this.VariableScheme = new List<VariableSchemeType>();
            this.VariableSchemeReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> LogicalProductName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<DataRelationshipType> DataRelationship { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 5)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 6)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<CategorySchemeType> CategoryScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> CategorySchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<CodeSchemeType> CodeScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ReferenceType> CodeSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<VariableSchemeType> VariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<ReferenceType> VariableSchemeReference { get; set; }
    }
}