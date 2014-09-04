using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class MeasureType
    {
        public MeasureType()
        {
            this.MeasureReference = new List<MeasureReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<MeasureReferenceType> MeasureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Value { get; set; }
    }
}