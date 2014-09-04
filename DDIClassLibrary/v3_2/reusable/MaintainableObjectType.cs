using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class MaintainableObjectType
    {
        public MaintainableObjectType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public TypeOfObjectType TypeOfObject { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public IDType MaintainableID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public VersionType MaintainableVersion { get; set; }
    }
}