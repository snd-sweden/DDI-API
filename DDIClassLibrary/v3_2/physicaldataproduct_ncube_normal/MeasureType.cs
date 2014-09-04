using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_2")]
    public class MeasureType
    {
        public MeasureType()
        {
            this.MeasureDefinitionReference = new List<MeasureDefinitionReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<MeasureDefinitionReferenceType> MeasureDefinitionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", Order = 1)]
        public PhysicalLocationType PhysicalLocation { get; set; }
    }
}