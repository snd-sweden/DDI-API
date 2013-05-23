using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class CorrespondenceType
    {
        public CorrespondenceType()
        {
            this.Commonality = new List<StructuredStringType>();
            this.Difference = new List<StructuredStringType>();
            this.UserDefinedCorrespondenceProperty = new List<UserDefinedCorrespondencePropertyType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<StructuredStringType> Commonality { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<StructuredStringType> Difference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType CommonalityTypeCoded { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public Nullable<float> CommonalityWeight { get; set; }

        public bool ShouldSerializeCommonalityWeight()
        {
            return CommonalityWeight.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<UserDefinedCorrespondencePropertyType> UserDefinedCorrespondenceProperty { get; set; }
    }
}