using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ExternalCategoryRepresentationBaseType : RepresentationType
    {
        public ExternalCategoryRepresentationBaseType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string ExternalCategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType UsageDescription { get; set; }
    }
}