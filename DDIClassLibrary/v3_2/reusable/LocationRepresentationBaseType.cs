using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LocationRepresentationBaseType : RepresentationType
    {
        public LocationRepresentationBaseType()
        {
            this.Action = new List<ActionType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Object { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ActionType> Action { get; set; }
    }
}