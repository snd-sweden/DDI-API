using System.Collections.Generic;
using DDIClassLibrary.v3_1.physicaldataproduct;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_1")]
    public class MeasureType
    {
        public MeasureType()
        {
            this.MeasureReference = new List<MeasureReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<MeasureReferenceType> MeasureReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", Order = 1)]
        public PhysicalLocationType PhysicalLocation { get; set; }
    }
}