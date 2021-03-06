﻿using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class LevelReferenceType
    {
        public LevelReferenceType()
        {
            this.GeographicLevelReference = new List<ReferenceType>();
            this.LevelName = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> GeographicLevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<string> LevelName { get; set; }
    }
}