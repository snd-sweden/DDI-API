using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NominalRepresentationBaseType : RepresentationType
    {
        public NominalRepresentationBaseType()
        {

        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string regExp { get; set; }            
    }
}