﻿using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.dataset
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dataset:3_1")]
    public class ItemValueType
    {
        public ItemValueType()
        {
            this.Value = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string RecordReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<string> Value { get; set; }
    }
}