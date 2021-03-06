﻿using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class StandardType
    {
        public StandardType()
        {
            this.Compliance = new List<ComplianceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public OtherMaterialType StandardUsed { get; set; }
    
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ComplianceType> Compliance { get; set; }

    }
}