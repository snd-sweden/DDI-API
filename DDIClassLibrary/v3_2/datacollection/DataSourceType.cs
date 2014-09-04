using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class DataSourceType
    {
        public DataSourceType()
        {
            this.SourceType = new List<CodeValueType>();
            this.Origin = new List<OriginType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public StructuredStringType SourceDescription { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> SourceType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<OriginType> Origin { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType SourceCharacteristic { get; set; }
    }
}