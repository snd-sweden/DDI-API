using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class GrossFileStructureType : IdentifiableType
    {
        public GrossFileStructureType()
        {
            this.ObjectType = "GrossFileStructure";

            this.ProcessingCheck = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string PlaceOfProduction { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> ProcessingCheck { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string ProcessingStatus { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public SoftwareType CreationSoftware { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public Nullable<int> CaseQuantity { get; set; }

        public bool ShouldSerializeCaseQuantity()
        {
            return CaseQuantity.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public Nullable<int> OverallRecordCount { get; set; }

        public bool ShouldSerializeOverallRecordCount()
        {
            return OverallRecordCount.HasValue;
        }
    }
}