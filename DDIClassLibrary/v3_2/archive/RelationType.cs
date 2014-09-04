﻿using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class RelationType : VersionableType
    {
        public RelationType()
        {
            this.Keyword = new List<InternationalCodeValueType>();
            this.EffectivePeriod = new List<DateType>();
            this.AdditionalInformation = new List<AdditionalInformationType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public SourceObjectType SourceObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public TargetObjectType TargetObject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<InternationalCodeValueType> Keyword { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<DateType> EffectivePeriod { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<AdditionalInformationType> AdditionalInformation { get; set; }
    }
}