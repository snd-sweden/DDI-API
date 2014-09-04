using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CategoryRepresentationBaseType : RepresentationType
    {
        public CategoryRepresentationBaseType()
        {

        }
        
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public SchemeReferenceType CategorySchemeReference { get; set; }
    
    }
}