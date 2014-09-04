using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_2")]
    public class MeasureType
    {
        public MeasureType()
        {
            this.MeasureDimensionValue = new List<MeasureDimensionValueType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<MeasureDimensionValueType> MeasureDimensionValue { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", Order = 1)]
        public PhysicalTableLocationType PhysicalTableLocation { get; set; }
    }
}