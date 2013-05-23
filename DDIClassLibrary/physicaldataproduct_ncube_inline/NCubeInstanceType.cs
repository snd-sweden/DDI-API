using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class NCubeInstanceType : VersionableType
    {
        public NCubeInstanceType()
        {
            this.ObjectType = "NCubeInstance";

            this.Attribute = new List<AttributeType>();
            this.DataItem = new List<DataItemType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType NCubeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<AttributeType> Attribute { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<DataItemType> DataItem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string DefaultDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string DefaultDelimiter { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public Nullable<int> DefaultDecimalPositions { get; set; }

        public bool ShouldSerializeDefaultDecimalPositions()
        {
            return DefaultDecimalPositions.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 6)]
        public OneCharStringType DefaultDecimalSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 7)]
        public OneCharStringType DefaultDigitGroupSeparator { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public Nullable<int> NumberOfCases { get; set; }

        public bool ShouldSerializeNumberOfCases()
        {
            return NumberOfCases.HasValue;
        }
    }
}