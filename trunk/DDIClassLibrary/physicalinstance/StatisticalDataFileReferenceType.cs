﻿using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class StatisticalDataFileReferenceType
    {
        public StatisticalDataFileReferenceType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool isInline { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType DataFileReference { get; set; }
    }
}