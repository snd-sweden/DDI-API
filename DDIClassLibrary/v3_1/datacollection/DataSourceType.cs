using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class DataSourceType
    {
        public DataSourceType()
        {
            this.SourceDescription = new List<StructuredStringType>();
            this.SourceType = new List<CodeValueType>();
            this.Origin = new List<OriginType>();
            this.Characteristic = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<StructuredStringType> SourceDescription { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> SourceType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<OriginType> Origin { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<StructuredStringType> Characteristic { get; set; }
    }
}