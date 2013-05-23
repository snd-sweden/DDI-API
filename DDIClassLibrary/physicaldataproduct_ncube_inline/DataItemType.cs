using System.Collections.Generic;

namespace DDIClassLibrary.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class DataItemType
    {
        public DataItemType()
        {
            this.Dimension = new List<DimensionType>();
            this.Attribute = new List<AttributeType>();
            this.Measure = new List<MeasureType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<DimensionType> Dimension { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<AttributeType> Attribute { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<MeasureType> Measure { get; set; }
    }
}