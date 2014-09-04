using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class LinkingMapType
    {
        public LinkingMapType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType LocalObjectReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType DepositoryObjectReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType RelationshipAction { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }
    }
}