using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_2")]
    public class PhysicalTableLocationType : PhysicalLocationType
    {
        public PhysicalTableLocationType()
        {            

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<int> ColumnNumber { get; set; }

        public bool ShouldSerializeColumnNumber()
        {
            return ColumnNumber.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> RowSequence { get; set; }

        public bool ShouldSerializeRowSequence()
        {
            return RowSequence.HasValue;
        }
    }
}