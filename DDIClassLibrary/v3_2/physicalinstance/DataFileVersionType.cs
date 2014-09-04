using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class DataFileVersionType
    {
        public DataFileVersionType()
        {

        }

        [System.Xml.Serialization.XmlAttribute()]
        public string versionNumber { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string versionDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string TypeOfVersionNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public string VersionResponsibility { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public ReferenceType VersionResponsibilityReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public VersionRationaleType VersionRationale { get; set; }
    }
}