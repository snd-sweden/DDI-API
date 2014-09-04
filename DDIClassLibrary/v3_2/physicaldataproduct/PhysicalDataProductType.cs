using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class PhysicalDataProductType : MaintainableType
    {
        public PhysicalDataProductType()
        {
            this.PhysicalDataProductName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.PhysicalStructureScheme = new List<PhysicalStructureSchemeType>();
            this.PhysicalStructureSchemeReference = new List<SchemeReferenceType>();
            this.RecordLayoutScheme = new List<RecordLayoutSchemeType>();
            this.RecordLayoutSchemeReference = new List<SchemeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> PhysicalDataProductName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<PhysicalStructureSchemeType> PhysicalStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<SchemeReferenceType> PhysicalStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<RecordLayoutSchemeType> RecordLayoutScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<SchemeReferenceType> RecordLayoutSchemeReference { get; set; }
    }
}