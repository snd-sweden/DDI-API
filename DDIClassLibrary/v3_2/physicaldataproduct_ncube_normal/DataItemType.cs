using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_2")]
    public class DataItemType
    {
        public DataItemType()
        {
            this.DimensionRankValue = new List<DimensionRankValueType>();
            this.AttachedAttribute = new List<AttachedAttributeType>();
            this.Measure = new List<MeasureType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<DimensionRankValueType> DimensionRankValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<AttachedAttributeType> AttachedAttribute { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<MeasureType> Measure { get; set; }
    }
}