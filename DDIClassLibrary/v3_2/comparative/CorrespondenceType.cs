using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class CorrespondenceType : MaintainableType
    {
        public CorrespondenceType()
        {
            this.UserDefinedCorrespondenceProperty = new List<StandardKeyValuePairType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public StructuredStringType Commonality { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Difference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType CommonalityTypeCoded { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public Nullable<float> CommonalityWeight { get; set; }

        public bool ShouldSerializeCommonalityWeight()
        {
            return CommonalityWeight.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public List<StandardKeyValuePairType> UserDefinedCorrespondenceProperty { get; set; }

    }
}