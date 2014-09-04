using System;
using DDIClassLibrary.v3_1.physicaldataproduct;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_1")]
    public class PhysicalTableLocationType : PhysicalLocationType
    {
        public PhysicalTableLocationType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public int Column { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> RowSequence { get; set; }

        public bool ShouldSerializeRowSequence()
        {
            return RowSequence.HasValue;
        }
    }
}