﻿using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_1")]
    public class VariableOrderType
    {
        public VariableOrderType()
        {
            this.VariableReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<ReferenceType> VariableReference { get; set; }
    }
}