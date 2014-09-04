using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ScaleRepresentationBaseType : RepresentationType
    {
        public ScaleRepresentationBaseType()
        {
            this.ScaleDimension = new List<ScaleDimensionType>();
            this.DimensionIntersect = new List<DimensionIntersectType>();
        }       
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ScaleDimensionType> ScaleDimension { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DimensionIntersectType> DimensionIntersect { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType DisplayLayout { get; set; }        
    }
}