using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class MeasureDimensionType
    {
        public MeasureDimensionType()
        {
            this.NCubeMeasureDefinitionReference = new List<NCubeMeasureDefinitionReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Namespace = "ddi:reusable:3_2", Order = 0)]
        public List<NCubeMeasureDefinitionReferenceType> NCubeMeasureDefinitionReference { get; set; }

    }
}