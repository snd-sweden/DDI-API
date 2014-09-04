using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class CategoryType : VersionableType
    {
        public CategoryType()
        {
            this.CategoryName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.SubCategoryReference = new List<SubCategoryReferenceType>();
        }

        private Nullable<bool> _missing;

        [System.Xml.Serialization.XmlAttribute()]
        public bool missing
        {
            get
            {
                if (_missing.HasValue)
                    return _missing.Value;
                return false; //default value;
            }
            set
            {
                this._missing = value;
            }
        }

        public bool ShouldSerializemissing()
        {
            return _missing.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CategoryName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ReferenceType ConceptReference { get; set; }

        public bool ShouldSerializeConceptReference()
        {
            return ConceptReference != null;
        }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public GenerationType Generation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<SubCategoryReferenceType> SubCategoryReference { get; set; }

    }
}