﻿namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class AnchorType
    {
        public AnchorType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string value { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType CategoryReference { get; set; }
    }
}