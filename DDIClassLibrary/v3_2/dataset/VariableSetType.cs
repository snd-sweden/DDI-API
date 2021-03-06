﻿using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_2")]
    public class VariableSetType
    {
        public VariableSetType()
        {
            this.VariableItem = new List<VariableItemType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<VariableItemType> VariableItem { get; set; }
    }
}